namespace Lykke.Service.Settings.Core.Domain
{
    public interface IExchangeSettings
    {
        string BaseAssetIos { get; }
        string BaseAssetOther { get; }
        bool SignOrder { get; }
    }
}
