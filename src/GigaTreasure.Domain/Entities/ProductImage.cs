using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.ProductImage;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents an entity for storing and managing product image data.
/// This class implements IProductImage and IProductImageBase interfaces to ensure
/// compliance with the defined structure of a product image in the GigaTreasure domain.
/// </summary>
[Table("ProductImages")]
public class ProductImage : IProductImage, IProductImageBase
{
    /// <summary>
    /// Gets or sets the unique identifier for the product image.
    /// This identifier is used to distinguish each product image
    /// within the system.
    /// </summary>
    public Guid ProductImageId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the product associated with the product image.
    /// This identifier is used to establish the relationship between a product and its image.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Represents the file path or URL of the image associated with a product.
    /// This property is used to store or retrieve the visual representation
    /// of the product in the form of an image.
    /// </summary>
    public string? Image { get; set; }
}