using Desafio.Core.Domain.Common;
using Desafio.Core.Domain.Entities;
using Desafio.Core.Domain.Interfaces;
using Desafio.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Infrastructure.Persistence.Repositories;

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