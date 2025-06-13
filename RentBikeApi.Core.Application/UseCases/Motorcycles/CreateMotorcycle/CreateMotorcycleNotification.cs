using MediatR;

namespace RentBikeApi.Core.Application.UseCases.Motorcycles.CreateMotorcycle;

public class CreateMotorcycleNotification : INotification
{
    public string Identifier { get; set; }
    public int Year { get; set; }
    public string LicensePlate { get; set; }
    public string Model { get; set; }
    
}