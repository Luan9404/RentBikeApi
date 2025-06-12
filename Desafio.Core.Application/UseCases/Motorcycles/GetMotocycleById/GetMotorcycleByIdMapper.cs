using AutoMapper;
using Desafio.Core.Domain.Entities;

namespace Desafio.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public class GetMotorcycleByIdMapper: Profile
{
    public GetMotorcycleByIdMapper()
    {
        CreateMap<Motorcycle, GetMotorcycleByIdResponse>();
    }
    
}