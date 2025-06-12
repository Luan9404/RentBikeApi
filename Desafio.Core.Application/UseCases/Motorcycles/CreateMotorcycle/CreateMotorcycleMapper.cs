using AutoMapper;
using Desafio.Core.Domain.Entities;

namespace Desafio.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleMapper: Profile
{
    public CreateMotorcycleMapper()
    {
        CreateMap<CreateMotorcycleRequest, Motorcycle>();
    }
}