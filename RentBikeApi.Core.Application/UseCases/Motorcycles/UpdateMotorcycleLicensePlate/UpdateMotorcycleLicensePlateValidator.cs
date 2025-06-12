using FluentValidation;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.UpdateMotorcycleLicensePlate;

public class UpdateMotorcycleLicensePlateValidator: AbstractValidator<UpdateMotorcycleLicensePlateRequest>
{
    public UpdateMotorcycleLicensePlateValidator()
    {
        RuleFor(request => request.LicensePlate).NotEmpty();
    }
}