using RentBikeApi.Core.Domain.Interfaces;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Persistence.Repositories;

public class UnityOfWork(AppDbContext context) : IUnityOfWork
{
    protected readonly AppDbContext Context = context;

    public async Task Commit()
    { 
        await Context.SaveChangesAsync();
    }
}