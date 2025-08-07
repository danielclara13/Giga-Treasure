using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.Product;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a product entity stored in the "Products" table.
/// Implements the <see cref="IProduct"/> and <see cref="IProductBase"/> interfaces to provide
/// unique identification and core properties for a product.
/// </summary>
[Table("Products")]
public class Product : IProduct, IProductBase
{
    /// <inheritdoc/>
    public Guid ProductId { get; set; }
    /// <inheritdoc/>
    public string? Name { get; set; }
    /// <inheritdoc/> 
    public string? Description { get; set; }
    /// <inheritdoc/>
    public decimal Price { get; set; }
    /// <inheritdoc/>
    public string? Manufacturer { get; set; }
    /// <inheritdoc/>
    public string? Model { get; set; }
}