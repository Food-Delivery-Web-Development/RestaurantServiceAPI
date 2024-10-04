namespace Restaurant.Service.Configurations;

using Context;
using Domain.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Repositories.Concretes;
using Repositories.Interfaces;
using Services.Concretes;
using Services.Interfaces;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        return services
            .ConfigureDatabase(configuration)
            .ConfigureControllers()
            .AddEndpointsApiExplorer()
            .ConfigureSwagger()
            .AddProblemDetails()
            .AddDependencies();
    }

    private static IServiceCollection ConfigureDatabase(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        _ = services.AddDbContext<PostgresContext>(options =>
        {
            _ = options.UseNpgsql(configuration.GetConnectionString("Postgres"));
        });

        return services;
    }

    private static IServiceCollection ConfigureControllers(this IServiceCollection services)
    {
        _ = services.AddControllers();

        return services;
    }

    private static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        return services.AddSwaggerGen(static c =>
        {
            c.SwaggerDoc(
                "v1",
                new OpenApiInfo { Title = "Restaurant Service API", Version = "v1" }
            );
        });
    }

    private static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        _ = services.AddScoped<IRepository<Address>, AddressRepository>();
        _ = services.AddScoped<IRepository<Product>, ProductRepository>();
        _ = services.AddScoped<IRepository<Restaurant>, RestaurantRepository>();

        _ = services.AddScoped<IService<Address>, AddressService>();
        _ = services.AddScoped<IService<Product>, ProductService>();
        _ = services.AddScoped<IService<Restaurant>, RestaurantService>();

        return services;
    }
}
