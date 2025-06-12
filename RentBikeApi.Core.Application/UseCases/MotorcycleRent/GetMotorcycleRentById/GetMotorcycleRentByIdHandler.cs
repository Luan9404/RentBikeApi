using AutoMapper;
using MediatR;
using RentBikeApi.Core.Domain.Interfaces;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;

public class GetMotorcycleRentByIdHandler(IMotorcycleRentRepository repository, IMapper mapper) : 
    IRequestHandler<GetMotorcycleRentByIdRequest, GetMotorcycleRentByIdResponse>
{
    public async Task<GetMotorcycleRentByIdResponse> Handle(GetMotorcycleRentByIdRequest request, CancellationToken cancellationToken)
    {
        var motorcycleRent = await repository.GetById(request.Id);
        if (motorcycleRent is null)
            throw new Exception();
        
        var result = mapper.Map<GetMotorcycleRentByIdResponse>(motorcycleRent);
        result.DailyValue = motorcycleRent.CalculateRentValue(); 
        
        return result;
    }
}