namespace GigaTreasure.Domain.Entities.Interfaces.Client;

/// <summary>
/// Represents a client entity with associated identification and address information.
/// </summary>
public interface IClient
{
    /// <summary>
    /// Gets or sets the unique identifier for a client.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the address associated with a client.
    /// </summary>
    public Guid AddressId { get; set; }
}