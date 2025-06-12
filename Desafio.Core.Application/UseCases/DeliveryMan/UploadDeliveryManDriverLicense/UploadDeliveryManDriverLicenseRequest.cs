using System.Text.Json.Serialization;
using MediatR;

namespace Desafio.Core.Application.UseCases.DeliveryMan.UploadDeliveryManDriverLicense;

public sealed record UploadDeliveryManDriverLicenseRequest(
    [property: JsonPropertyName("imagem_cnh")] string Image,
    string Identifier): IRequest;
