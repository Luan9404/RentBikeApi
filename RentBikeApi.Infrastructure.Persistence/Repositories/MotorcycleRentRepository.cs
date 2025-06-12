using Microsoft.EntityFrameworkCore;
using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Persistence.Repositories;

public class MotorcycleRentRepository(AppDbContext context) : BaseRepository<MotorcycleRent>(context), IMotorcycleRentRepository
{
    public new async Task<MotorcycleRent> GetById(Guid id)
    {
        return await Context.MotorcycleRent
            .Include(x => x.Motorcycle)
            .Include(x => x.DeliveryMan)
            .FirstOrDefaultAsync(x => x.Id == id && x.DeletedAt == null);
    }
}