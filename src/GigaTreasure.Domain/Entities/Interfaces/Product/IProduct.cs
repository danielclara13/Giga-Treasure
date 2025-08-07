namespace GigaTreasure.Domain.Entities.Interfaces.Product;

/// <summary>
/// Defines the contract for a product entity.
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Gets or sets the unique identifier for the product.
    /// </summary>
    public Guid ProductId { get; set; }
}