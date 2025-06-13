using RentBikeApi.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RentBikeApi.Infrastructure.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    
    public DbSet<Motorcycle> Motorcycle { get; set; }
    public DbSet<DeliveryMan> DeliveryMan { get; set; }
    public DbSet<MotorcycleRent> MotorcycleRent { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Motorcycle>()
            .HasIndex(b => b.LicensePlate)
            .IsUnique();
        
        modelBuilder.Entity<DeliveryMan>()
            .HasIndex(x => x.DriverLicense)
            .IsUnique();
        
        modelBuilder.Entity<DeliveryMan>()
            .HasIndex(x => x.TaxNumber)
            .IsUnique();
        
    }
}