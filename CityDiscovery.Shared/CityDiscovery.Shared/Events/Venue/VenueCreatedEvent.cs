namespace CityDiscovery.Shared.Events.Venue;

/// <summary>
/// Published when a new venue is created in the system.
/// Includes essential fields for search indexing and notifications.
/// Categories stored as simple list - no complex objects or full entity graph.
/// </summary>
public class VenueCreatedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid VenueId { get; init; }
    public string City { get; init; } = string.Empty;
    public List<string> Categories { get; init; } = new();
    public string Description { get; init; } = string.Empty;
}
