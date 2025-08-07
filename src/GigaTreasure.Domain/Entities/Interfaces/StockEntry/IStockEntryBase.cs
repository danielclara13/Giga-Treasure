namespace GigaTreasure.Domain.Entities.Interfaces.StockEntry;

/// <summary>
/// Defines the basic structure for a stock entry entity.
/// </summary>
public interface IStockEntryBase
{
    /// <summary>
    /// Gets or sets the quantity of items or stock associated with the entry.
    /// Represents the numeric value indicating the amount in inventory or stock record.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Represents the date associated with the stock entry.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the name or identifier of the supplier associated with the stock entry.
    /// </summary>
    public string? Supplier { get; set; }
}