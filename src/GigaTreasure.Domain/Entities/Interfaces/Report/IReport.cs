namespace GigaTreasure.Domain.Entities.Interfaces.Report;

/// <summary>
/// Represents a report entity containing details such as the associated report ID, client ID, and comment ID.
/// </summary>
public interface IReport
{
    /// <summary>
    /// Gets or sets the unique identifier for the report.
    /// </summary>
    public Guid ReportId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the client associated with the report.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the comment associated with the report.
    /// </summary>
    public Guid CommentId { get; set; }
}