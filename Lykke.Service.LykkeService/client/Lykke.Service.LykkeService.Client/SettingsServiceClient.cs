using System;
using Common.Log;

namespace Lykke.Service.Settings.Client
{
    public class SettingsServiceClient : ISettingsServiceClient, IDisposable
    {
        private readonly ILog _log;

        public SettingsServiceClient(string serviceUrl, ILog log)
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
