using GigaTreasure.Domain.Entities.Interfaces.Comment;

namespace GigaTreasure.Domain.Entities;

/// <summary>
/// Represents a comment entity used to associate feedback or remarks with a specific product and client.
/// Implements both <see cref="IComment"/> and <see cref="ICommentBase"/> to provide a complete
/// structure for comment-related functionalities in the application.
/// </summary>
public class Comment : IComment, ICommentBase
{
    /// <inheritdoc cref="IComment.CommentId" />
    public Guid CommentId { get; set; }

    /// <inheritdoc cref="IComment.ClientId" />
    public Guid ClientId { get; set; }

    /// <inheritdoc cref="IComment.ProductId" />
    public Guid ProductId { get; set; }

    /// <inheritdoc cref="ICommentBase.Text" />
    public string? Text { get; set; }
}