using Desafio.Core.Domain.Interfaces;
using MediatR;

namespace Desafio.Core.Application.UseCases.Motorcycles.UpdateMotorcycleLicensePlate;

public class UpdateMotorcycleLicensePlateHandler(IMotorcycleRepository repository, IUnityOfWork unityOfWork)
    : IRequestHandler<UpdateMotorcycleLicensePlateRequest>
{
    private readonly IMotorcycleRepository _repository = repository;
    private IUnityOfWork _unityOfWork = unityOfWork;

    public async Task Handle(UpdateMotorcycleLicensePlateRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = await _repository.GetByIdentifier(request.Identifier);
        if (motorcycle is null)
            throw new Exception("No such motorcycle");
        
        motorcycle.LicensePlate = request.LicensePlate;
        _repository.Update(motorcycle);
        
        await _unityOfWork.Commit();
    }
}