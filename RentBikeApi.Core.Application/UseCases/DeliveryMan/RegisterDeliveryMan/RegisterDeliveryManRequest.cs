using System.Text.Json.Serialization;
using MediatR;
using RentBikeApi.Core.Domain.Enums;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;

public sealed record RegisterDeliveryManRequest(
    [property: JsonPropertyName("identificador")]
    string Identifier,
    [property: JsonPropertyName("nome")] string Name,
    [property: JsonPropertyName("cnpj")] string TaxNumber,
    [property: JsonPropertyName("data_nascimento")]
    DateTime BirthDay,
    [property: JsonPropertyName("numero_cnh")]
    string DriverLicense,
    [property: JsonPropertyName("tipo_cnh")]
    DriverLicenseTypes DriverLicenseType,
    [property: JsonPropertyName("imagem_cnh")]
    string? DriverLicenseImage): IRequest;