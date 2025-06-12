using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Common;

namespace RentBikeApi.Core.Domain.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetById(Guid id);
    Task<IEnumerable<T>> GetAll();
}