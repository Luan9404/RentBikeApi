using System.Text.Json.Serialization;
using RentBikeApi.Core.Domain.Entities;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public sealed record GetMotorcycleByIdRequest([property: JsonPropertyName("id")] string Id) : 
    IRequest<GetMotorcycleByIdResponse>; 