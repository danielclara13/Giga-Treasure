using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.Client;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a client entity in the system, containing identification, address, and credential-related properties.
/// Implements the <see cref="IClient"/> and <see cref="IClientBase"/> interfaces.
/// </summary>
[Table("Clients")]
public class Client : IClient, IClientBase
{
    /// <inheritdoc />
    public Guid ClientId { get; set; }

    /// <inheritdoc />
    public Guid AddressId { get; set; }

    /// <inheritdoc />
    public string? Username { get; set; }

    /// <inheritdoc />
    public string? Password { get; set; }

    /// <inheritdoc />
    public string? Nif { get; set; }

    /// <inheritdoc />
    public string? FullName { get; set; }

    /// <inheritdoc />
    public bool? Banned { get; set; }
}