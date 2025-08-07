namespace GigaTreasure.Domain.Entities.Interfaces.Product;

/// <summary>
/// Represents the base interface for a product entity,
/// encapsulating common product properties such as name, description, price, manufacturer, and model.
/// </summary>
public interface IProductBase
{
    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Represents a textual description of the product.
    /// Provides details or additional context about the product's features, usage, or specifications.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Represents the price of the product.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer of the product.
    /// </summary>
    /// <remarks>
    /// The Manufacturer property represents the name of the entity or company
    /// that created or produced the product. This information can be used to
    /// identify the origin of the product or for categorization purposes.
    /// </remarks>
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the model information of the product.
    /// </summary>
    public string? Model { get; set; }
}