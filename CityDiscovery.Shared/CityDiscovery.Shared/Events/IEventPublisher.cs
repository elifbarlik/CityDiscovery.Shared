namespace CityDiscovery.Shared.Events;

/// <summary>
/// Abstraction for publishing integration events to the message broker.
/// Implementations are broker-agnostic and support various messaging infrastructures
/// (Kafka, RabbitMQ, Azure Service Bus, etc.).
/// </summary>
/// <remarks>
/// <para><strong>Fire-and-Forget Semantics:</strong></para>
/// Publishing is intentionally decoupled from business logic success.
/// Business transactions MUST NOT depend on successful event delivery.
/// 
/// <para><strong>Recommended Implementation:</strong></para>
/// Use the Outbox Pattern to ensure reliable event delivery without coupling
/// business logic to broker availability.
/// 
/// <para><strong>Testability:</strong></para>
/// This abstraction enables easy mocking in unit tests, allowing domain logic
/// to be tested without real message broker infrastructure.
/// </remarks>
public interface IEventPublisher
{
    /// <summary>
    /// Publishes an integration event asynchronously.
    /// </summary>
    /// <param name="integrationEvent">The event to publish.</param>
    /// <returns>A task that completes when the event is queued for publishing.</returns>
    /// <remarks>
    /// <para><strong>IMPORTANT:</strong> This method does NOT guarantee immediate delivery.</para>
    /// <para>When using the Outbox Pattern, this stores the event in the outbox table.</para>
    /// <para>When using direct publishing, this sends to the broker but may fail silently.</para>
    /// <para>Business logic should never await this for success confirmation.</para>
    /// </remarks>
    Task PublishAsync(IIntegrationEvent integrationEvent);
}
