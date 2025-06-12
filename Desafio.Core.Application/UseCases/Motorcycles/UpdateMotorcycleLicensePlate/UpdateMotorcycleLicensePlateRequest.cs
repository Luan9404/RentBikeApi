using System.Text.Json.Serialization;
using MediatR;

namespace Desafio.Core.Application.UseCases.Motorcycles.UpdateMotorcycleLicensePlate;

public sealed record UpdateMotorcycleLicensePlateRequest(
    [property: JsonPropertyName("placa")]
    string LicensePlate,
    [property: JsonPropertyName("id")]
    string Identifier
    ): IRequest;