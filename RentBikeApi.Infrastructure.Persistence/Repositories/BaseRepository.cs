using RentBikeApi.Core.Domain.Common;
using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Persistence.Repositories;

public class BaseRepository<T>(AppDbContext context) : IBaseRepository<T>
    where T : BaseEntity
{
    protected readonly AppDbContext Context = context;

    public void Create(T entity)
    {
        entity.CreatedAt = DateTimeOffset.UtcNow;
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DeletedAt = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public async Task<T> GetById(Guid id)
    {
        return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id && x.DeletedAt == null);
    }
    
    public async Task<IEnumerable<T>> GetAll()
    {
        return await Context.Set<T>().Where(x => x.DeletedAt == null).ToListAsync();
    }
}