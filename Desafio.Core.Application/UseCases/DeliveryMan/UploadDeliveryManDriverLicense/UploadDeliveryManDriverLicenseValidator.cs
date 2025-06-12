using FluentValidation;

namespace Desafio.Core.Application.UseCases.DeliveryMan.UploadDeliveryManDriverLicense;

public class UploadDeliveryManDriverLicenseValidator: AbstractValidator<UploadDeliveryManDriverLicenseRequest>
{
    public UploadDeliveryManDriverLicenseValidator()
    {
        RuleFor(x => x.Image).NotNull().NotEmpty();       
    }
}