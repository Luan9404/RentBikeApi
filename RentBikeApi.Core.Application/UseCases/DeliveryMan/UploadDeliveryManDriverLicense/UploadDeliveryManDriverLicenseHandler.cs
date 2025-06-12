using System.Net.Mime;
using RentBikeApi.Core.Domain.Interfaces;
using MediatR;
using System.IO;
using System.Drawing;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.UploadDeliveryManDriverLicense;

public class UploadDeliveryManDriverLicenseHandler(
    IDeliveryManRepository repository,
    IUnityOfWork unityOfWork)
    : IRequestHandler<UploadDeliveryManDriverLicenseRequest>
{
    private readonly IDeliveryManRepository _repository = repository;
    private readonly IUnityOfWork _unityOfWork = unityOfWork;

    public async Task Handle(UploadDeliveryManDriverLicenseRequest request, CancellationToken cancellationToken)
    {
        var deliveryMan = await _repository.GetByIdentifier(request.Identifier);
        
        string cleanBase64 = request.Image.Contains(',') ? request.Image.Substring(request.Image.LastIndexOf(',')) : 
            request.Image;
        var imageBytes = Convert.FromBase64String(cleanBase64);

        string filename = $"{deliveryMan.Id}.png";
        
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        var fullPath = Path.Combine(baseDirectory, "images", filename); 
        string? directory = Path.GetDirectoryName(fullPath);
        
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
        
        await File.WriteAllBytesAsync(fullPath, imageBytes);
        deliveryMan.DriverLicenseImage = fullPath;

        await _unityOfWork.Commit();
    }
}