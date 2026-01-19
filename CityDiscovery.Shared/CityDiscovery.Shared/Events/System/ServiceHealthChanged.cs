namespace CityDiscovery.Shared.Events.System;

/// <summary>
/// Published when a service's health status changes (e.g., healthy, degraded, down).
/// Used for monitoring, alerting, and circuit breaker patterns.
/// </summary>
public class ServiceHealthChanged : IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredAt { get; init; }
    public Guid CorrelationId { get; init; }
    public string ProducerService { get; init; } = "System";
    public int EventVersion { get; init; } = 1;

    // Domain-specific payload
    public string ServiceName { get; init; } = string.Empty;
    public string PreviousStatus { get; init; } = string.Empty; // "Healthy", "Degraded", "Down"
    public string CurrentStatus { get; init; } = string.Empty;
    public string? Reason { get; init; }
}
