using RentBikeApi.Core.Domain.Common;

namespace RentBikeApi.Core.Domain.Entities;

public class Motorcycle : BaseEntity
{
    public string Identifier { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public List<MotorcycleRent> Rents { get; set; } = new List<MotorcycleRent>();

}