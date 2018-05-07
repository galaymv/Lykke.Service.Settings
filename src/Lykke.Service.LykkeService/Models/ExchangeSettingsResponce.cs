using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.Settings.Models
{
    public class ExchangeSettingsResponse : IExchangeSettings
    {
        public string BaseAssetIos { get; }
        public string BaseAssetOther { get; }
        public bool SignOrder { get; }

        public ExchangeSettingsResponse(IExchangeSettings settings)
        {
            BaseAssetIos = settings.BaseAssetIos;
            BaseAssetOther = settings.BaseAssetOther;
            SignOrder = settings.SignOrder;
        }
    }
}
