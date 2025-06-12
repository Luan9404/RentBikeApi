using AutoMapper;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

public class RegisterRentMapper: Profile
{
    public RegisterRentMapper()
    {
        CreateMap<RegisterRentRequest, Domain.Entities.MotorcycleRent>();
    }
    
}