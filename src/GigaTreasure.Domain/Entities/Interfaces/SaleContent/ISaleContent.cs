namespace GigaTreasure.Domain.Entities.Interfaces.SaleContent;

/// <summary>
/// Represents the contract for a sale content entity, defining the properties for sale content identification, associated sale, and related product.
/// </summary>
public interface ISaleContent
{
    /// <summary>
    /// Gets or sets the unique identifier for the sale content.
    /// </summary>
    public Guid SaleContentId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the sale associated with the content.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the product associated with the sale content.
    /// </summary>
    public Guid ProductId { get; set; }
}