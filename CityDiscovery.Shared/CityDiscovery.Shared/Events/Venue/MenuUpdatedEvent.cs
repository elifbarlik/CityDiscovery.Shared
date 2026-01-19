namespace CityDiscovery.Shared.Events.Venue;

/// <summary>
/// Lightweight DTO for menu items - NOT a database entity.
/// Used only in event payloads to avoid coupling to database schema.
/// </summary>
public class MenuItemDto
{
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; }
    public string Category { get; init; } = string.Empty;
}

/// <summary>
/// Published when a venue's menu is updated.
/// Contains lightweight DTOs - no EF entities, no navigation properties.
/// Enables search indexing and recommendations without database schema coupling.
/// </summary>
public class MenuUpdatedEvent : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Venue";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload - minimal by design
    public Guid VenueId { get; init; }
    
    /// <summary>
    /// Simple DTOs containing only essential menu data.
    /// NOT full database entities - reduces payload size and coupling.
    /// </summary>
    public List<MenuItemDto> MenuItems { get; init; } = new();
}
