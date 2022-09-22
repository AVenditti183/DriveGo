using System;

namespace DriveGo.Infrastructure.RabbitMQ
{
    public interface IMassTransitEndpointConfiguration
    {
        string Queue { get; }
        Type[] ConsumerTypes { get; }
    }
}