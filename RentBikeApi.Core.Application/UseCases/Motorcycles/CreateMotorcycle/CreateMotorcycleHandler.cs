using AutoMapper;
using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleHandler(
    IMotorcycleRepository repository, 
    IMapper mapper, 
    IUnityOfWork unityOfWork, 
    IMediator mediator)
    : IRequestHandler<CreateMotorcycleRequest>
{

    public async Task Handle(CreateMotorcycleRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = mapper.Map<Motorcycle>(request);
        
        repository.Create(motorcycle);

        await unityOfWork.Commit();
        
        var notification = mapper.Map<CreateMotorcycleNotification>(motorcycle);

        await mediator.Publish(notification, cancellationToken);
    }
}