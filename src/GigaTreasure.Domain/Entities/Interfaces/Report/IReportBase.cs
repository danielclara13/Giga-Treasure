namespace GigaTreasure.Domain.Entities.Interfaces.Report;

/// <summary>
/// Represents the base structure for a report in the GigaTreasure system.
/// </summary>
public interface IReportBase
{
    /// <summary>
    /// Gets or sets a value indicating whether the report has been seen.
    /// </summary>
    /// <remarks>
    /// A nullable boolean property that reflects the viewed state of the report.
    /// A value of <c>true</c> indicates the report has been seen, <c>false</c> indicates it has not been seen,
    /// and <c>null</c> indicates the state is unspecified.
    /// </remarks>
    public bool? Seen { get; set; }

    /// <summary>
    /// Gets or sets the textual content associated with the report.
    /// Represents a description or content relevant to the report.
    /// </summary>
    public string? Text { get; set; }

    /// Gets or sets the date associated with the report.
    /// This property represents the date or timestamp related to the report instance.
    /// The value of this property is of type `DateTime`.
    /// It is used for tracking or displaying when the report was created, modified, or referenced.
    public DateTime Date { get; set; }
}