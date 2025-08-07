using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.SaleContent;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a sale content entity, which includes details about a product
/// associated with a particular sale, such as pricing, quantity, and total content amount.
/// Implements the <see cref="ISaleContent"/> and <see cref="ISaleContentBase"/> interfaces.
/// </summary>
[Table("SaleContents")]
public class SaleContent : ISaleContent, ISaleContentBase
{
    /// <inheritdoc/>
    public Guid SaleContentId { get; set; }
    /// <inheritdoc/>
    public Guid SaleId { get; set; }
    /// <inheritdoc/>
    public Guid ProductId { get; set; }
    /// <inheritdoc/>
    public decimal ProductPrice { get; set; }
    /// <inheritdoc/>
    public int Quantity { get; set; }
    /// <inheritdoc/>
    public decimal ContentAmount { get; set; }
}