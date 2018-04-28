using System;
using Common.Log;
using Lykke.Service.Settings.Client;

namespace Lykke.Service.LykkeService.Client
{
    public class LykkeServiceClient : ILykkeServiceClient, IDisposable
    {
        private readonly ILog _log;

        public LykkeServiceClient(string serviceUrl, ILog log)
        {
            _log = log;
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
