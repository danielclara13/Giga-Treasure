namespace GigaTreasure.Domain.Entities.Interfaces.Client;

/// <summary>
/// Represents the base interface for a client entity containing essential credential and identification properties.
/// </summary>
public interface IClientBase
{
    /// <summary>
    /// Gets or sets the Username of the client.
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// Gets or sets the password for the client.
    /// This property contains the client's password information
    /// and may include null if the password is not set.
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Gets or sets the NIF (Número de Identificación Fiscal).
    /// This property represents the tax identification number associated with the client.
    /// </summary>
    public string? Nif { get; set; }

    /// <summary>
    /// Gets or sets the full name of the client.
    /// Represents the complete name of the individual associated with the client.
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// Indicates whether the user is banned.
    /// A value of true represents a banned state, while false indicates the user is not banned.
    /// Can be null if the banned state is not specified.
    /// </summary>
    public bool? Banned { get; set; }
}