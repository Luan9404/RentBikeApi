using System.Reflection;
using RentBikeApi.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentBikeApi.Infrastructure.Persistence.Context;
using RentBikeApi.Infrastructure.Persistence.Repositories;

namespace RentBikeApi.Infrastructure.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Postgres");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString, 
            x => x.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));
        services.AddScoped<IMotorcycleRepository, MotorCycleRepository>();
        services.AddScoped<IDeliveryManRepository, DeliveryManRepository>();
        services.AddScoped<IUnityOfWork, UnityOfWork>();
        services.AddScoped<IMotorcycleRentRepository, MotorcycleRentRepository>();
    }
}