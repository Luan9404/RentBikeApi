using System.Text.Json.Serialization;
using MediatR;
using RentBikeApi.Core.Domain.Enums;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

public sealed record RegisterRentRequest(
    [property: JsonPropertyName("entregador_id")]
    string DeliveryManIdentifier,
    [property: JsonPropertyName("moto_id")]
    string MotorcycleIdentifier,
    [property: JsonPropertyName("data_inicio")]
    DateTime StartDate,
    [property: JsonPropertyName("data_termino")]
    DateTime EndDate,
    [property: JsonPropertyName("data_previsao_termino")]
    DateTime? ExpectedEndDate,
    [property: JsonPropertyName("plano")]
    Plans Plan): IRequest;