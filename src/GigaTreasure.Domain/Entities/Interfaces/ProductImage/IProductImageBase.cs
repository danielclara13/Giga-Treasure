namespace GigaTreasure.Domain.Entities.Interfaces.ProductImage;

/// <summary>
/// Defines the base structure for a product image entity within the GigaTreasure domain.
/// </summary>
public interface IProductImageBase
{
    /// <summary>
    /// Represents the image associated with a product. This property is used to store
    /// the image information, which could be a file path, URL, or encoded image data.
    /// </summary>
    public string? Image { get; set; }
}