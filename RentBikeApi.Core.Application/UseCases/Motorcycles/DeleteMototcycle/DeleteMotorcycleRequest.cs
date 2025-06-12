using System.Text.Json.Serialization;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.DeleteMototcycle;

public sealed record DeleteMotorcycleRequest([property: JsonPropertyName("Id")]string Identifier) : IRequest;