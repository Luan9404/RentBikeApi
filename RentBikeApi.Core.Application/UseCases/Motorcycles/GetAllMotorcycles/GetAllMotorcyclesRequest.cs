using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetAllMotorcycles;

public sealed record GetAllMotorcyclesRequest(string? LicensePlate): IRequest<List<GetAllMotorcyclesResponse>>;