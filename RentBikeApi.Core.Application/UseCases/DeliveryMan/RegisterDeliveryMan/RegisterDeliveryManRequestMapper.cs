using AutoMapper;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;

public class RegisterDeliveryManRequestMapper: Profile
{
    public RegisterDeliveryManRequestMapper()
    {
        CreateMap<RegisterDeliveryManRequest, Domain.Entities.DeliveryMan>();
    }
    
}