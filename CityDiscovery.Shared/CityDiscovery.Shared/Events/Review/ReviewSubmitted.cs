namespace CityDiscovery.Shared.Events.Review;

/// <summary>
/// Published when a user submits a review for a venue.
/// Triggers notifications, updates venue ratings, and may require moderation.
/// </summary>
public class ReviewSubmitted : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Review";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload
    public Guid ReviewId { get; init; }
    public Guid VenueId { get; init; }
    public Guid UserId { get; init; }
    public int Rating { get; init; } // e.g., 1-5
    public bool HasPhotos { get; init; }
    public DateTime SubmittedAt { get; init; }
}
