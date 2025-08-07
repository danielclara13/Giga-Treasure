namespace GigaTreasure.Domain.Entities.Interfaces.Address;

/// <summary>
/// Represents the base interface for an address entity providing properties
/// commonly related to address details such as street name, number, apartment,
/// and postal code.
/// </summary>
public interface IAddressBase
{
    /// <summary>
    /// Gets or sets the street information of the address.
    /// This property specifies the name of the street associated with the address.
    /// The value is expected to be a string, but it can be null to represent a missing or unspecified street.
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Gets or sets the numerical designation of the address, typically representing
    /// the house or building number.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the apartment or unit information related to the address.
    /// This property specifies the apartment, suite, or unit number associated with the address.
    /// The value is optional and can be null to indicate no specific apartment or unit is applicable.
    /// </summary>
    public string? Apartment { get; set; }

    /// Gets or sets the postal code associated with the address.
    /// The postal code is used for identifying specific geographic regions
    /// for mailing and navigation purposes. It can include numeric or alphanumeric
    /// values depending on the region.
    public string? PostalCode { get; set; }
}