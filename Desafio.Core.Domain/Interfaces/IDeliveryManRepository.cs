using Desafio.Core.Domain.Entities;

namespace Desafio.Core.Domain.Interfaces;

public interface IDeliveryManRepository: IBaseRepository<DeliveryMan>
{
    Task<DeliveryMan> GetByIdentifier(string image);
}