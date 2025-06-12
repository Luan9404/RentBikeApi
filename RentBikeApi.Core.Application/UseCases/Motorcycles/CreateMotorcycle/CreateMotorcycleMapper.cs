using AutoMapper;
using RentBikeApi.Core.Domain.Entities;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleMapper: Profile
{
    public CreateMotorcycleMapper()
    {
        CreateMap<CreateMotorcycleRequest, Motorcycle>();
    }
}