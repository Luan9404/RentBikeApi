using Desafio.Core.Domain.Interfaces;
using Desafio.Infrastructure.Persistence.Context;

namespace Desafio.Infrastructure.Persistence.Repositories;

public class UnityOfWork(AppDbContext context) : IUnityOfWork
{
    protected readonly AppDbContext Context = context;

    public async Task Commit()
    { 
        await Context.SaveChangesAsync();
    }
}