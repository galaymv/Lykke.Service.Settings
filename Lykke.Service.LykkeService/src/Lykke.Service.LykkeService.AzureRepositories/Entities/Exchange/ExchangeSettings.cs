using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.LykkeService.AzureRepositories.Entities.Exchange
{
    public class ExchangeSettings : IExchangeSettings
    {
        public string BaseAssetIos { get; set; }
        public string BaseAssetOther { get; set; }
        public bool SignOrder { get; set; }
    }
}
