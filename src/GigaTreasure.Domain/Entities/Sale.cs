using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.Sale;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a sale entity in the system. The Sale class provides information
/// about a specific transaction, including its identifier, the client involved,
/// the date of the transaction, and the final amount.
/// Implements the ISale and ISaleBase interfaces, which define the fundamental
/// properties for a sale.
/// </summary>
[Table("Sales")]
public class Sale : ISale, ISaleBase
{
    /// <inheritdoc/>
    public Guid SaleId { get; set; }
    /// <inheritdoc/> 
    public Guid ClientId { get; set; }
    /// <inheritdoc/>
    public DateTime Date { get; set; }
    /// <inheritdoc/>
    public decimal FinalAmount { get; set; }
}