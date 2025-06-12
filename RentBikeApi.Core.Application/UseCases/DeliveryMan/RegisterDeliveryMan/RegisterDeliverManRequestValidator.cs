using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;

public class RegisterDeliverManRequestValidator: AbstractValidator<RegisterDeliveryManRequest>
{
    public RegisterDeliverManRequestValidator()
    {
        RuleFor(x=> x.Identifier).NotNull().NotEmpty();
        RuleFor(x=> x.Name).NotNull().NotEmpty();
        RuleFor(x => x.BirthDay).NotNull().NotEmpty();
        RuleFor(x => x.DriverLicense).NotNull().NotEmpty();
        RuleFor(x => x.DriverLicenseType).NotNull().NotEmpty();
        // tipo de cnh RuleFor(x => x.DriverLicenseType).;
        RuleFor(x => x.TaxNumber).NotNull().NotEmpty();
    }
}