using RentBikeApi.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.DeleteMototcycle;

public class DeleteMotorcycleHandler(IMotorcycleRepository repository, IUnityOfWork unityOfWork)
    : IRequestHandler<DeleteMotorcycleRequest>
{
    private readonly IMotorcycleRepository _repository = repository;
    private readonly IUnityOfWork _unityOfWork = unityOfWork;

    public async Task Handle(DeleteMotorcycleRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = await _repository.GetByIdentifier(request.Identifier);
        
        if (motorcycle == null)
            throw new Exception();
        
        _repository.Delete(motorcycle);
        
        await _unityOfWork.Commit();
    }
}