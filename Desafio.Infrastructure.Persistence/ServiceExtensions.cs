using Desafio.Core.Domain.Interfaces;
using Desafio.Infrastructure.Persistence.Context;
using Desafio.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Infrastructure.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Core");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));
        services.AddScoped<IMotorcycleRepository, MotorCycleRepository>();
        services.AddScoped<IDeliveryManRepository, DeliveryManRepository>();
        services.AddScoped<IUnityOfWork, UnityOfWork>();
    }
}