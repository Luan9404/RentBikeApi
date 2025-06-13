using Microsoft.EntityFrameworkCore;
using RentBikeApi.Infrastructure.Persistence.Context;

namespace RentBikeApi.Infrastructure.Data;

class Program
{
    static void Main(string[] args)
        => CreateHostBuilder(args).Build().Run();

    private static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddDbContextPool<AppDbContext>(options =>
                    options.UseNpgsql(
                        hostContext.Configuration.GetConnectionString("Postgres"),
                        b => b.MigrationsAssembly(typeof(Program).Assembly.FullName)
                    )
                );
            });
}