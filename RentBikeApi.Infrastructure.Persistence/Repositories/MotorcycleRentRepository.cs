using RentBikeApi.Core.Domain.Entities;
using RentBikeApi.Core.Domain.Interfaces;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Persistence.Repositories;

public class MotorcycleRentRepository(AppDbContext context) : BaseRepository<MotorcycleRent>(context), IMotorcycleRentRepository
{
    
}