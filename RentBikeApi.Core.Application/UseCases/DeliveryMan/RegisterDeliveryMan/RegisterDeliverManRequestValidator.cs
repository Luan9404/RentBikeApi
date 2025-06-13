using FluentValidation;
using RentBikeApi.Core.Domain.Enums;

namespace RentBikeApi.Core.Application.UseCases.DeliveryMan.RegisterDeliveryMan;

public class RegisterDeliverManRequestValidator: AbstractValidator<RegisterDeliveryManRequest>
{
    public RegisterDeliverManRequestValidator()
    {
        RuleFor(x=> x.Identifier).NotNull().NotEmpty();
        RuleFor(x=> x.Name).NotNull().NotEmpty();
        RuleFor(x => x.BirthDay).NotNull().NotEmpty();
        RuleFor(x => x.DriverLicense).NotNull().NotEmpty();
        RuleFor(x => x.DriverLicenseType).NotNull().IsInEnum();
        RuleFor(x => x.DriverLicenseType).Equal(DriverLicenseTypes.A);
        RuleFor(x => x.TaxNumber).NotNull().NotEmpty();
    }
}