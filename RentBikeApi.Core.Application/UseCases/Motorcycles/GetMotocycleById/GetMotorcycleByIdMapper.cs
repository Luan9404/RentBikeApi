using AutoMapper;
using RentBikeApi.Core.Domain.Entities;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public class GetMotorcycleByIdMapper: Profile
{
    public GetMotorcycleByIdMapper()
    {
        CreateMap<Motorcycle, GetMotorcycleByIdResponse>();
    }
    
}