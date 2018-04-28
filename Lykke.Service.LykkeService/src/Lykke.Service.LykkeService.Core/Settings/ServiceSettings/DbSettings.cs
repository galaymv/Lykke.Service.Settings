﻿using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.LykkeService.Core.Settings.ServiceSettings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
