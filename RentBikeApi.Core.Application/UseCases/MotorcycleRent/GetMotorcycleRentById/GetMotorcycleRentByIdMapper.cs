using AutoMapper;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;

public class GetMotorcycleRentByIdMapper: Profile
{
    public GetMotorcycleRentByIdMapper()
    {
        CreateMap<Domain.Entities.MotorcycleRent, GetMotorcycleRentByIdResponse>()
            .ForMember(x => x.MotorcycleIdentifier,
                opt =>
                    opt.MapFrom(src => src.Motorcycle.Identifier))

            .ForMember(x => x.DeliveryManIdentifier,
                opt =>
                    opt.MapFrom(src => src.DeliveryMan.Identifier))
            
            .ForMember(x => x.Identifier,
                opt =>
                    opt.MapFrom(src => src.Id));
    }
    
}