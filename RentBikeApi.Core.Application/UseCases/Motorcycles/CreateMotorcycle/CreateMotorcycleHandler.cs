using AutoMapper;
using Desafio.Core.Domain.Entities;
using Desafio.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleHandler(IMotorcycleRepository repository, IMapper mapper, IUnityOfWork unityOfWork)
    : IRequestHandler<CreateMotorcycleRequest>
{
    private readonly IMotorcycleRepository _repository = repository;
    private readonly IMapper _mapper = mapper;
    private readonly IUnityOfWork _unityOfWork = unityOfWork;

    public async Task Handle(CreateMotorcycleRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = _mapper.Map<Motorcycle>(request);
        
        _repository.Create(motorcycle);

        await _unityOfWork.Commit();
    }
}