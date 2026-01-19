namespace CityDiscovery.Shared.Events.UserInteractions;

/// <summary>
/// Published when a new user successfully registers in the Identity service.
/// Other services can use this to create user profiles, initialize preferences, etc.
/// </summary>
public class UserCreated : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "Identity";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload
    public Guid UserId { get; init; }
    public string Email { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public DateTime RegisteredAt { get; init; }
}
