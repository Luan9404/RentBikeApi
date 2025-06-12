using System.Text.Json.Serialization;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public sealed record CreateMotorcycleRequest(
    [property: JsonPropertyName("identificador")]
    string Identifier,
    [property: JsonPropertyName("ano")] int Year,
    [property: JsonPropertyName("modelo")] string Model,
    [property: JsonPropertyName("placa")] string LicensePlate)
    : IRequest;