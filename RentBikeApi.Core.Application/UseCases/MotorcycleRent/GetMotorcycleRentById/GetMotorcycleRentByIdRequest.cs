using System.Text.Json.Serialization;
using MediatR;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;

public sealed record GetMotorcycleRentByIdRequest(Guid Id): IRequest<GetMotorcycleRentByIdResponse>;