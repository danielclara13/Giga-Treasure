using GigaTreasure.Domain.Configuration;
using GigaTreasure.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GigaTreasure.Infra.Data;

/// <summary>
/// Provides extension methods for configuring services in the application's DI container.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Configures the database context for the application using MySQL.
    /// </summary>
    /// <param name="services">The service collection to which the database context will be added.</param>
    /// <param name="configuration">The application configuration used to retrieve connection strings.</param>
    private static void ConfigureDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionStringsConfiguration = new ConnectionStringsConfiguration();
        configuration.Bind(ConnectionStringsConfiguration.SectionName, connectionStringsConfiguration);

        services.AddDbContext<GigaTreasureDbContext>(options =>
        {
            options.UseMySql(connectionStringsConfiguration.DatabaseConnection,
                ServerVersion.AutoDetect(connectionStringsConfiguration.DatabaseConnection),
                mysqlOptions =>
                {
                    mysqlOptions.EnableStringComparisonTranslations();
                    mysqlOptions.MigrationsAssembly(typeof(GigaTreasureDbContext).Assembly.FullName);
                });
        });
    }

    /// <summary>
    /// Adds the persistence layer services, including database context configuration, to the service collection.
    /// </summary>
    /// <param name="serviceCollection">The service collection to which the persistence layer services will be added.</param>
    /// <param name="configuration">The application configuration used to configure the persistence layer services.</param>
    /// <returns>The updated service collection with added persistence layer services.</returns>
    public static IServiceCollection AddPersistenceLayerServices(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(serviceCollection);

        serviceCollection.ConfigureDatabaseContext(configuration);

        return serviceCollection;
    }
}