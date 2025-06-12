using AutoMapper;
using RentBikeApi.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public class GetMotorcycleByIdHandler(IMotorcycleRepository repository, IMapper mapper)
    : IRequestHandler<GetMotorcycleByIdRequest, GetMotorcycleByIdResponse>
{
    private readonly IMapper _mapper = mapper;

    public async Task<GetMotorcycleByIdResponse> Handle(GetMotorcycleByIdRequest request, CancellationToken cancellationToken)
    {
        var motorcycle = await repository.GetByIdentifier(request.Id);
        
        if (motorcycle == null)
            throw new Exception();
        
        var result = _mapper.Map<GetMotorcycleByIdResponse>(motorcycle); 
        return result;
    }
}