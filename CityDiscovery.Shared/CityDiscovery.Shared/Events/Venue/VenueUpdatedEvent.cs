namespace CityDiscovery.Shared.Events.Venue;

/// <summary>
/// Published when venue data is updated.
/// Contains only field names that changed - NOT full values.
/// This tells consumers "something changed" without duplicating database state.
/// Consumers query their own projections or call APIs for latest data if needed.
/// </summary>
public class VenueUpdatedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid VenueId { get; init; }
    
    /// <summary>
    /// Names of fields that changed (e.g., ["Name", "Description", "Categories"]).
    /// Signals cache invalidation or re-indexing without duplicating full entity.
    /// </summary>
    public List<string> ChangedFields { get; init; } = new();
}
