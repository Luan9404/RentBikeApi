using System.Text.Json.Serialization;
using MediatR;

namespace Desafio.Core.Application.UseCases.Motorcycles.DeleteMototcycle;

public sealed record DeleteMotorcycleRequest([property: JsonPropertyName("Id")]string Identifier) : IRequest;