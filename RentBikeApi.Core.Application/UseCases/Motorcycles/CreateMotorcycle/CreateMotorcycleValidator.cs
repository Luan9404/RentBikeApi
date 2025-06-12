using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleValidator: AbstractValidator<CreateMotorcycleRequest>
{
    public CreateMotorcycleValidator()
    {
        RuleFor(x => x.Identifier).NotEmpty();
        RuleFor(x => x.LicensePlate).NotEmpty();
        RuleFor(x => x.Model).NotEmpty();
        RuleFor(x => x.Year).NotEmpty();
    }
    
}