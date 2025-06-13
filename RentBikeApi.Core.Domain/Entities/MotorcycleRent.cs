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

    public decimal CalculateRentValue()
    {
        var baseValue = (int)Plan * GetBaseDailyValue(Plan);

        if (EndDate > ExpectedEndDate)
            return CalculateLateReturnRent(baseValue, (EndDate - ExpectedEndDate).Days);
        
        if(EndDate < ExpectedEndDate)
            return CalculateEarlyReturnRent((ExpectedEndDate - EndDate).Days, Plan);
        
        return baseValue;
    }

    private static decimal GetBaseDailyValue(Plans plan)
    {
        return plan switch
        {
            Plans.Days7 => 30,
            Plans.Days15 => 28,
            Plans.Days30 => 22,
            Plans.Days45 => 20,
            Plans.Days50 => 18,
            _ => throw new ArgumentOutOfRangeException(nameof(plan), plan, null)
        };
    }

    private decimal CalculateLateReturnRent(decimal baseValue, int days)
    {
        return baseValue + (50 * days);
    }

    private decimal CalculateEarlyReturnRent(int days, Plans plan)
    {
        decimal remainingDailies = GetBaseDailyValue(plan) * days;
        decimal effectedDailies =  GetBaseDailyValue(plan) * ((int)plan - days);

        var fineValue = plan switch
        {
            Plans.Days7 => remainingDailies * 0.2m,
            Plans.Days15 => remainingDailies * 0.4m,
            _ => 0
        };
        
        return effectedDailies + fineValue;
    }
}