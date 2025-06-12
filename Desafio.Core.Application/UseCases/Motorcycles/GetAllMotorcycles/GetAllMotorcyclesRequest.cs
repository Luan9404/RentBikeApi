using MediatR;

namespace Desafio.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;

public sealed record GetAllMotorcyclesRequest(string? LicensePlate): IRequest<List<GetAllMotorcyclesResponse>>;