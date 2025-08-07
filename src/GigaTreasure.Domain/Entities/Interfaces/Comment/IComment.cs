namespace GigaTreasure.Domain.Entities.Interfaces.Comment;

/// <summary>
/// Defines a contract for a comment entity, commonly used to associate feedback or remarks
/// with a specific product and client.
/// </summary>
public interface IComment
{
    /// Gets or sets the unique identifier for the comment.
    public Guid CommentId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the client associated with the comment.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the product associated with the comment.
    /// </summary>
    public Guid ProductId { get; set; }
}