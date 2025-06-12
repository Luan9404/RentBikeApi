using FluentValidation;

namespace Desafio.Core.Application.UseCases.Motorcycles.DeleteMototcycle;

public class DeleteMotorcycleValidator: AbstractValidator<DeleteMotorcycleRequest>
{
    public DeleteMotorcycleValidator()
    {
        RuleFor(x => x.Identifier).NotEmpty();        
    }
}