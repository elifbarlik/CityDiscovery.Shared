namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a user saves/bookmarks a post.
/// Minimal payload avoids coupling to Post entity schema changes.
/// Enables personalization and recommendation without full entity knowledge.
/// </summary>
public class PostSavedEvent : IIntegrationEvent
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
}
