namespace CityDiscovery.Shared.Events;

/// <summary>
/// Base contract that all integration events must implement.
/// Provides core fields for event-driven microservices communication.
/// </summary>
public interface IIntegrationEvent
{
    /// <summary>
    /// Unique identifier for this event instance.
    /// Used for idempotency checks to prevent duplicate processing.
    /// </summary>
    Guid EventId { get; }

    /// <summary>
    /// UTC timestamp when the event was created.
    /// Enables chronological ordering and time-based filtering of events.
    /// </summary>
    DateTime OccurredAt { get; }

    /// <summary>
    /// Correlation identifier linking related events across service boundaries.
    /// Essential for distributed tracing and saga orchestration.
    /// </summary>
    Guid CorrelationId { get; }

    /// <summary>
    /// Name of the microservice that published this event.
    /// Aids in debugging, monitoring, and understanding event flow.
    /// </summary>
    string ProducerService { get; }

    /// <summary>
    /// Version number of the event schema.
    /// Supports backward compatibility and graceful evolution of event contracts.
    /// </summary>
    int EventVersion { get; }
}
