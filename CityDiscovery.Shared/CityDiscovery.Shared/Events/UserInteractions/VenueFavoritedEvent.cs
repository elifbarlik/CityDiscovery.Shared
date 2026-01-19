namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a user favorites/bookmarks a venue.
/// Minimal payload (just IDs) reduces message size and network overhead.
/// Enables personalization engine without venue schema knowledge.
/// </summary>
public class VenueFavoritedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid UserId { get; init; }
    public Guid VenueId { get; init; }
}
