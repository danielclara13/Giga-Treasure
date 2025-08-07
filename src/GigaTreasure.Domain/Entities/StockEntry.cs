using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.StockEntry;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a stock entry in the system, modeling the details of inventory stock activities.
/// Implements the <see cref="IStockEntry"/> and <see cref="IStockEntryBase"/> interfaces.
/// </summary>
[Table("StockEntries")]
public class StockEntry : IStockEntry, IStockEntryBase
{
    /// <inheritdoc/>
    public Guid StockEntryId { get; set; }
    /// <inheritdoc/>
    public Guid ProductId { get; set; }
    /// <inheritdoc/> 
    public int Quantity { get; set; }
    /// <inheritdoc/>
    public DateTime Date { get; set; }
    /// <inheritdoc/>
    public string? Supplier { get; set; }
}