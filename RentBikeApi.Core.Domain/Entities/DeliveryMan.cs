using RentBikeApi.Core.Domain.Common;
using RentBikeApi.Core.Domain.Enums;

namespace RentBikeApi.Core.Domain.Entities;

public class DeliveryMan: BaseEntity
{
   public string Identifier { get; set; }
   public string Name { get; set; }
   public string TaxNumber { get; set; }
   public DateTime Birthday { get; set; }
   public string DriverLicense { get; set; }
   public DriverLicenseTypes DriverLicenseType { get; set; }
   public string? DriverLicenseImage { get; set; }
   public List<MotorcycleRent> Rents { get; set; } = new List<MotorcycleRent>();
}