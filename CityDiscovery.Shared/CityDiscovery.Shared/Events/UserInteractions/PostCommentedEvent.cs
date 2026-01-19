namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a user comments on a post.
/// Includes CommentText for moderation and notification purposes.
/// No full Post or User entities - keeps payload lightweight and decoupled.
/// </summary>
public class PostCommentedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Social";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid UserId { get; init; }
    public Guid PostId { get; init; }
    public Guid VenueId { get; init; }
    public string CommentText { get; init; } = string.Empty;
}
