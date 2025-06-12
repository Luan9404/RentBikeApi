using Desafio.Core.Domain.Entities;
using Desafio.Core.Domain.Interfaces;
using Desafio.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Infrastructure.Persistence.Repositories;

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
        return await Context.Motorcycle.FirstOrDefaultAsync(x=> x.Identifier == identifier && x.DeletedAt == null);
    }
}