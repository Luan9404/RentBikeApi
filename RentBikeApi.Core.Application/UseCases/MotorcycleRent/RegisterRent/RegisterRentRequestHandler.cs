using AutoMapper;
using MediatR;
using RentBikeApi.Core.Domain.Interfaces;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

public class RegisterRentRequestHandler(
    IMotorcycleRepository motorcycleRepository, 
    IDeliveryManRepository deliveryManRepository,
    IMotorcycleRentRepository motorcycleRentRepository,
    IMapper mapper,
    IUnityOfWork unityOfWork): IRequestHandler<RegisterRentRequest>
{
    
    public async Task Handle(RegisterRentRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = await motorcycleRepository.GetByIdentifier(request.MotorcycleIdentifier);
        if (motorcycle is null)
            throw new ArgumentException("Moto não encontrada.");

        var deliveryMan = await deliveryManRepository.GetByIdentifier(request.DeliveryManIdentifier);
        if (deliveryMan is null)
            throw new ArgumentException("Entregador não encontrado.");

        var rent = mapper.Map<Domain.Entities.MotorcycleRent>(request);
        motorcycleRentRepository.Create(rent);

        await unityOfWork.Commit();

    }
}