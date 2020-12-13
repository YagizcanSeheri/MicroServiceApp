﻿using RabbitMQ.Client;
using System;
namespace EventBusRabbitMQ.Connection.Interfaces
{
    public interface IRabbitMQConnection:IDisposable
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
