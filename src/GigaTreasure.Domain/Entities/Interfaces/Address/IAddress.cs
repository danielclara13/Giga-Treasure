namespace GigaTreasure.Domain.Entities.Interfaces.Address;

/// <summary>
/// Represents an interface for defining the structure of an address within the domain.
/// </summary>
public interface IAddress
{
    /// <summary>
    /// Gets or sets the unique identifier for the address.
    /// </summary>
    public Guid AddressId { get; set; }
}