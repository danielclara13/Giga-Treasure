using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.Address;

namespace GigaTreasure.Domain.Entities;

/// <summary>
///     Represents the Address entity for the domain, combining properties related to both
///     address identification and detailed address information.
/// </summary>
/// <remarks>
///     This class implements both IAddress and IAddressBase interfaces, which define its structure
///     and the properties it must include. It is mapped to the "Address" table in the database.
/// </remarks>
[Table("Address")]
public class Address : IAddress, IAddressBase
{
    /// <inheritdoc cref="IAddress.AddressId" />
    public Guid AddressId { get; set; }

    /// <inheritdoc cref="IAddressBase.Street" />
    public string? Street { get; set; }

    /// <inheritdoc cref="IAddressBase.Number" />
    public int Number { get; set; }

    /// <inheritdoc cref="IAddressBase.Apartment" />
    public string? Apartment { get; set; }

    /// <inheritdoc cref="IAddressBase.PostalCode" />
    public string? PostalCode { get; set; }
}