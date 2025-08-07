using System.ComponentModel.DataAnnotations.Schema;
using GigaTreasure.Domain.Entities.Interfaces.Report;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a report entity in the system.
/// The report contains information such as report ID, client ID, comment ID,
/// a flag indicating whether the report has been seen, a textual description,
/// and the date it was created or logged.
/// </summary>
[Table("Reports")]
public class Report : IReport, IReportBase
{
    /// <inheritdoc cref="IReport.ReportId" />
    public Guid ReportId { get; set; }
    /// <inheritdoc cref="IReport.ClientId" />
    public Guid ClientId { get; set; }
    /// <inheritdoc cref="IReport.CommentId" />
    public Guid CommentId { get; set; }
    /// <inheritdoc cref="IReportBase.Seen" />
    public bool? Seen { get; set; }
    /// <inheritdoc cref="IReportBase.Text" />
    public string? Text { get; set; }
    /// <inheritdoc cref="IReportBase.Date" />
    public DateTime Date { get; set; }
}