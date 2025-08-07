namespace GigaTreasure.Domain.Entities.Interfaces.Sale;

/// <summary>
/// Represents a contract for sale-related entities within the system.
/// Provides a unique identifier for a sale.
/// </summary>
public interface ISale
{
    /// <summary>
    /// Gets or sets the unique identifier for a sale.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for a client associated with the sale.
    /// </summary>
    public Guid ClientId { get; set; }
}