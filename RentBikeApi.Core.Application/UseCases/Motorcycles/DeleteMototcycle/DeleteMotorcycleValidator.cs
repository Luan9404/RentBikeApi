using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.DeleteMototcycle;

public class DeleteMotorcycleValidator: AbstractValidator<DeleteMotorcycleRequest>
{
    public DeleteMotorcycleValidator()
    {
        RuleFor(x => x.Identifier).NotEmpty();        
    }
}