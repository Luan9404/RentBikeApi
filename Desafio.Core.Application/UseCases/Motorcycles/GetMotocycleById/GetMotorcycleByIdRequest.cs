using System.Text.Json.Serialization;
using Desafio.Core.Domain.Entities;
using MediatR;

namespace Desafio.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public sealed record GetMotorcycleByIdRequest([property: JsonPropertyName("id")] string Id) : 
    IRequest<GetMotorcycleByIdResponse>; 