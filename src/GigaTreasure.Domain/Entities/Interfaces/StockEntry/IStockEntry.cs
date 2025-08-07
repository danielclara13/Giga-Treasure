namespace GigaTreasure.Domain.Entities.Interfaces.StockEntry;

/// <summary>
/// Represents a stock entry within the GigaTreasure domain.
/// </summary>
public interface IStockEntry
{
    /// <summary>
    /// Gets or sets the unique identifier for the stock entry.
    /// </summary>
    public Guid StockEntryId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the product associated with the stock entry.
    /// </summary>
    public Guid ProductId { get; set; }
}