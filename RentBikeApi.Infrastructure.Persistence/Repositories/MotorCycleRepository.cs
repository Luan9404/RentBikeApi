using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Persistence.Repositories;

public class MotorCycleRepository(AppDbContext context) : BaseRepository<Motorcycle>(context), IMotorcycleRepository
{
    public async Task<Motorcycle> GetByLicensePlate(string plate)
    {
        return await Context.Motorcycle.FirstOrDefaultAsync(x=> x.LicensePlate == plate && x.DeletedAt == null);
    }

    public async Task<IEnumerable<Motorcycle>> GetAll(string? licensePlate)
    {
        return await Context.Motorcycle.Where(x => 
            (string.IsNullOrEmpty(licensePlate) || x.LicensePlate == licensePlate) && x.DeletedAt == null)
            .ToListAsync();
    }
    public async Task<Motorcycle> GetByIdentifier(string identifier)
    {
        return await Context.Motorcycle
            .Include(x => x.Rents)
            .FirstOrDefaultAsync(x=> x.Identifier == identifier && x.DeletedAt == null);
    }
}