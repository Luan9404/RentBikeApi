using RentBikeApi.Core.Domain.Entities;

namespace RentBikeApi.Core.Domain.Interfaces;

public interface IDeliveryManRepository: IBaseRepository<DeliveryMan>
{
    Task<DeliveryMan> GetByIdentifier(string image);
}