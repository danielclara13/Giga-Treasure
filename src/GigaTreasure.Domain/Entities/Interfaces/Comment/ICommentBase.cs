namespace GigaTreasure.Domain.Entities.Interfaces.Comment;

/// <summary>
/// Represents the base interface for a comment entity.
/// Provides the foundational structure for comment-related properties in implementing classes.
/// </summary>
public interface ICommentBase
{
    /// <summary>
    /// Gets or sets the textual content of the comment.
    /// </summary>
    public string? Text { get; set; }
}