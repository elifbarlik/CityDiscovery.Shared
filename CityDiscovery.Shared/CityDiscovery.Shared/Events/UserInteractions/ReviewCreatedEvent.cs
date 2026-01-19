namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a user creates a review for a venue.
/// Contains Rating and ReviewText for immediate processing (moderation, sentiment analysis).
/// Avoids full Review entity to reduce payload size and coupling.
/// </summary>
public class ReviewCreatedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Review";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid UserId { get; init; }
    public Guid VenueId { get; init; }
    public int Rating { get; init; }
    public string ReviewText { get; init; } = string.Empty;
}
