using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.GetMotocycleById;

public class GetMotorcycleByIdValidator : AbstractValidator<GetMotorcycleByIdRequest>
{
    public GetMotorcycleByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}