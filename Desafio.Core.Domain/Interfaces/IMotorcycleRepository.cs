using Desafio.Core.Domain.Entities;

namespace Desafio.Core.Domain.Interfaces;

public interface IMotorcycleRepository: IBaseRepository<Motorcycle>
{
   Task<Motorcycle> GetByLicensePlate(string plate); 
   Task<Motorcycle> GetByIdentifier(string identifier);
   Task<IEnumerable<Motorcycle>> GetAll(string? licensePlate);
}