using System.Text.Json.Serialization;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.UploadDeliveryManDriverLicense;

public sealed record UploadDeliveryManDriverLicenseRequest(
    [property: JsonPropertyName("imagem_cnh")] string Image,
    string Identifier): IRequest;
