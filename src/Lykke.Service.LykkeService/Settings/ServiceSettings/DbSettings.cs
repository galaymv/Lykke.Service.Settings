using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Settings.Settings.ServiceSettings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
