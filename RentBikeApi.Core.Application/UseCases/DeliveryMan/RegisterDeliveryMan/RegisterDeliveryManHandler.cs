using AutoMapper;
using RentBikeApi.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;

public class RegisterDeliveryManHandler(IMapper mapper, IDeliveryManRepository repository, IUnityOfWork unityOfWork)
    : IRequestHandler<RegisterDeliveryManRequest>
{
    private readonly IMapper _mapper = mapper;
    private readonly IDeliveryManRepository _repository = repository;
    private readonly IUnityOfWork _unityOfWork = unityOfWork;

    public async Task Handle(RegisterDeliveryManRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<RegisterDeliveryManRequest, Domain.Entities.DeliveryMan>(request);
        
        _repository.Create(entity);
        
        await _unityOfWork.Commit();
    }
}