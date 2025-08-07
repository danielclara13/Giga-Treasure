namespace GigaTreasure.Domain.Entities.Interfaces.ProductImage;

/// <summary>
/// Represents an interface for product image entities, defining the
/// properties required for identifying and associating a product image
/// with a specific product.
/// </summary>
public interface IProductImage
{
    /// <summary>
    /// Gets or sets the unique identifier for the product image.
    /// </summary>
    public Guid ProductImageId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the associated product.
    /// </summary>
    public Guid ProductId { get; set; }
}