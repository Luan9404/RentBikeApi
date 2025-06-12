using RentBikeApi.Core.Domain.Entities;

namespace RentBikeApi.Core.Domain.Interfaces;

public interface IMotorcycleRepository: IBaseRepository<Motorcycle>
{
   Task<Motorcycle> GetByLicensePlate(string plate); 
   Task<Motorcycle> GetByIdentifier(string identifier);
   Task<IEnumerable<Motorcycle>> GetAll(string? licensePlate);
}