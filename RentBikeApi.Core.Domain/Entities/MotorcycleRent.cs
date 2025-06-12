using RentBikeApi.Core.Domain.Common;
using RentBikeApi.Core.Domain.Enums;

namespace RentBikeApi.Core.Domain.Entities;

public class MotorcycleRent : BaseEntity
{
    public Guid MotorcycleId { get; set; }
    public Guid DeliveryManId { get; set; }
    public DeliveryMan DeliveryMan { get; set; }
    public Motorcycle Motorcycle { get; set; }
    public DateTime InitialDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ExpectedEndDate { get; set; }
    public Plans Plan { get; set; }
}