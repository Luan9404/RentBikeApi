using AutoMapper;
using Desafio.Core.Domain.Entities;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;

public class GetAllMotorcyclesMapper: Profile
{
    public GetAllMotorcyclesMapper()
    {
        CreateMap<Motorcycle, GetAllMotorcyclesResponse>();
    }
    
}