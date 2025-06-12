using Desafio.Core.Domain.Common;
using Desafio.Core.Domain.Enums;

namespace Desafio.Core.Domain.Entities;

public class MotorcycleRent : BaseEntity
{
    public DeliveryMan DeliveryMan { get; set; }
    public Motorcycle Motorcycle { get; set; }
    public DateTime InitialDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ExpectedEndDate { get; set; }
    public Plans Plan { get; set; }
}