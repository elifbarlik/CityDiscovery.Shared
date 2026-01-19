namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a user likes a post.
/// Minimal payload supports: analytics, recommendation engine, notification service.
/// Consumers fetch full details from their own databases if needed.
/// </summary>
public class PostLikedEvent : IIntegrationEvent
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
