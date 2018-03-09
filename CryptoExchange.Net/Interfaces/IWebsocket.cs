﻿using System;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace CryptoExchange.Net.Interfaces
{
    public interface IWebsocket
    {
        void SetEnabledSslProtocols(SslProtocols protocols);

        event Action OnClose;
        event Action<string> OnMessage;
        event Action<Exception> OnError;
        event Action OnOpen;

        bool IsClosed { get; }
        bool IsOpen { get; }

        Task<bool> Connect();
        void Send(string data);
        Task Close();
        void SetProxy(string host, int port);
    }
}
