namespace GigaTreasure.Domain.Configuration;

/// <summary>
/// Represents the configuration settings for connection strings.
/// </summary>
public class ConnectionStringsConfiguration
{
    /// <summary>
    /// Configuration property name.
    /// </summary>
    public const string SectionName = "ConnectionStrings";

    /// <summary>
    /// Gets or sets a database connection string.
    /// </summary>
    public string DatabaseConnection { get; set; } = string.Empty;
}