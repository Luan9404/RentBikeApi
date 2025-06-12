using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.MotorcycleRent.RegisterRent;

public class RegisterRentValidator: AbstractValidator<RegisterRentRequest>
{
    public RegisterRentValidator()
    {
        RuleFor(x => x.DeliveryManIdentifier)
            .NotEmpty()
            .WithMessage("O identificador do entregador não pode ser vazio.");

        RuleFor(x => x.MotorcycleIdentifier)
            .NotEmpty()
            .WithMessage("O identificador da moto não pode ser vazio.");

        RuleFor(x => x.StartDate)
            .NotEmpty()
            .WithMessage("A data de início não pode ser vazia.");

        RuleFor(x => x.ExpectedEndDate)
            .NotEmpty()
            .WithMessage("A data prevista para término não pode ser vazia.")
            .GreaterThanOrEqualTo(x => x.EndDate)
            .WithMessage("A data prevista para término deve ser maior ou igual à data de término.");

        RuleFor(x => x.Plan)
            .IsInEnum()
            .WithMessage("O plano selecionado é inválido.");
    }
    
}