namespace GigaTreasure.Domain.Entities.Interfaces.SaleContent;

/// <summary>
/// Represents the base definition for a sale content entity,
/// providing properties related to product pricing, quantity,
/// and content amount.
/// </summary>
public interface ISaleContentBase
{
    /// <summary>
    /// Represents the price of a product in the sale content.
    /// </summary>
    /// <remarks>
    /// This property encapsulates the monetary value assigned to the product.
    /// It is expected to be a decimal value to accurately represent currency.
    /// </remarks>
    public decimal ProductPrice { get; set; }

    /// <summary>
    /// Represents the quantity of the sale content.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the total amount calculated for the content.
    /// This amount is derived based on the product price and its quantity.
    /// </summary>
    public decimal ContentAmount { get; set; }
}