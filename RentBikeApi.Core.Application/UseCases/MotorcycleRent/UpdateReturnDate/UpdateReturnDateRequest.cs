using MediatR;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.UpdateReturnDate;

public sealed record UpdateReturnDateRequest(string Id): IRequest;