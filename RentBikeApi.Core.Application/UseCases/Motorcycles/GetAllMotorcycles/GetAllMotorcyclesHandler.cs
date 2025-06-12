using AutoMapper;
using Desafio.Core.Domain.Entities;
using Desafio.Core.Domain.Interfaces;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;

public class GetAllMotorcyclesHandler(IMapper mapper, IMotorcycleRepository repository)
    : IRequestHandler<GetAllMotorcyclesRequest, List<GetAllMotorcyclesResponse>>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMotorcycleRepository _repository = repository;

    public async Task<List<GetAllMotorcyclesResponse>> Handle(GetAllMotorcyclesRequest request, CancellationToken cancellationToken)
    {
        var motorcycles = await _repository.GetAll(request.LicensePlate);
        return _mapper.Map<List<GetAllMotorcyclesResponse>>(motorcycles);
    }
}