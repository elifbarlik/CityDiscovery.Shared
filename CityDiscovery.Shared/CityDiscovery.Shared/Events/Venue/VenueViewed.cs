namespace CityDiscovery.Shared.Events.Venue;

/// <summary>
/// Published when a user views a venue's detail page.
/// Used for analytics, recommendations, and tracking popular venues.
/// </summary>
public class VenueViewed : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload
    public Guid VenueId { get; init; }
    public Guid? UserId { get; init; } // Nullable for anonymous users
    public string VenueName { get; init; } = string.Empty;
    public string VenueCategory { get; init; } = string.Empty;
    public string UserIpAddress { get; init; } = string.Empty;
}
