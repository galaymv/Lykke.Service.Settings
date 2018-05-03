using System;
using Autofac;
using Common.Log;
using Lykke.Service.LykkeService.Client;

namespace Lykke.Service.Settings.Client
{
    public static class AutofacExtension
    {
        public static void RegisterLykkeServiceClient(this ContainerBuilder builder, string serviceUrl, ILog log)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (serviceUrl == null) throw new ArgumentNullException(nameof(serviceUrl));
            if (log == null) throw new ArgumentNullException(nameof(log));
            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(serviceUrl));

            builder.RegisterType<SettingsServiceClient>()
                .WithParameter("serviceUrl", serviceUrl)
                .As<ISettingsServiceClient>()
                .SingleInstance();
        }

        public static void RegisterLykkeServiceClient(this ContainerBuilder builder, SettingsServiceClientSettings settings, ILog log)
        {
            builder.RegisterLykkeServiceClient(settings?.ServiceUrl, log);
        }
    }
}
