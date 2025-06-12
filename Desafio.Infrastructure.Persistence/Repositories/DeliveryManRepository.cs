using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using Desafio.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Infrastructure.Persistence.Repositories;

public class DeliveryManRepository(AppDbContext context) : BaseRepository<DeliveryMan>(context), IDeliveryManRepository
{
    public async Task<DeliveryMan> GetByIdentifier(string identifier)
    {
        return await Context.DeliveryMan.FirstOrDefaultAsync(x => x.Identifier == identifier);
    }
}