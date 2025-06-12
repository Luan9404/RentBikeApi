using Desafio.Core.Domain.Common;

namespace Desafio.Core.Domain.Entities;

public class Motorcycle : BaseEntity
{
    public string Identifier { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public List<MotorcycleRent> Rents { get; set; } = new List<MotorcycleRent>();

}