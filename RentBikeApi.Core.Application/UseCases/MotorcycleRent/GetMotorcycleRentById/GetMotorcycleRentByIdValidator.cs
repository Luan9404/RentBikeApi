using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.GetMotorcycleRentById;

public class GetMotorcycleRentByIdValidator: AbstractValidator<GetMotorcycleRentByIdRequest>
{
    public GetMotorcycleRentByIdValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
    }
    
}