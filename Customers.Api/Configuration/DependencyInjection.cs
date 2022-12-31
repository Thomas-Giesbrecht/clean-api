using Customers.Api.Database;
using Customers.Api.Repositories;
using Customers.Api.Services;
using FastEndpoints;
using FastEndpoints.Swagger;

namespace Customers.Api.Configuration;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddFastEndpoints();
        services.AddSingleton<IDbConnectionFactory>(_ => new DbConnectionFactory("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=postgres;"));
        services.AddSingleton<DatabaseInitializer>();
    }

    public static void AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<ICustomerRepository, CustomerRepository>();
        services.AddSingleton<ICustomerService, CustomerService>();
    }

    public static void AddPresentation(this IServiceCollection services)
    {
        services.AddSwaggerDoc();
    }
}