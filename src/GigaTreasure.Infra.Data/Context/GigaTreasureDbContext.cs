using Microsoft.EntityFrameworkCore;

namespace GigaTreasure.Infra.Data.Context;

/// <summary>
/// Represents the database context for the GigaTreasure application.
/// </summary>
/// <remarks>
/// This class is derived from the DbContext class provided by Entity Framework Core and is used to interact with the database.
/// It provides configurations and mappings for the application's data models.
/// </remarks>
/// <example>
/// This context is typically configured and used with dependency injection to access and manage the application's database.
/// </example>
/// <threadsafety>
/// This class is not thread-safe. Ensure that instances of this context are scoped appropriately within application services.
/// </threadsafety>
public class GigaTreasureDbContext(DbContextOptions<GigaTreasureDbContext> options) : DbContext(options)
{
    /// <summary>
    /// Configures the model relationships, entity properties, and database mappings for the application's data models.
    /// </summary>
    /// <param name="modelBuilder">
    /// An instance of <see cref="ModelBuilder"/> that provides the APIs for configuring the Entity Framework Core model.
    /// </param>
    /// <remarks>
    /// This method is automatically called during the initialization of the database context.
    /// Override this method to define custom configurations such as entity relationships, table mappings, constraints, or indexes.
    /// </remarks>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
}