using System.Reflection;
using Desafio.Core.Application.Behavior;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Core.Application.Services;

public static class ServiceExtensions
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    }
    
}