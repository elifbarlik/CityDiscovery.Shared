namespace CityDiscovery.Shared.Events.Venue;

/// <summary>
/// Published when a new event (e.g., concert, promotion, special occasion) is created for a venue.
/// Minimal payload for notifications and event discovery features.
/// Full details remain in the owning service - consumers fetch on-demand.
/// </summary>
public class EventCreatedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid VenueId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
}
