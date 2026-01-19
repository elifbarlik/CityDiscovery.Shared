namespace CityDiscovery.Shared.Events.Content;

/// <summary>
/// Published when content (article, guide, tip) is published in the Content service.
/// Can trigger notifications, search indexing, or analytics updates.
/// </summary>
public class ArticlePublished : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Content";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload
    public Guid ArticleId { get; init; }
    public Guid AuthorId { get; init; }
    public string Title { get; init; } = string.Empty;
    public string ContentType { get; init; } = string.Empty; // "Article", "Guide", "Tip"
    public DateTime PublishedAt { get; init; }
}
