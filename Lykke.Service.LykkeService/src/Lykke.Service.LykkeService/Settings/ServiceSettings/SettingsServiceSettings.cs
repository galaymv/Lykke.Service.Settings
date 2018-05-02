using JetBrains.Annotations;

namespace Lykke.Service.Settings.Settings.ServiceSettings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class SettingsServiceSettings
    {
        public string[] BlockedAssetPairs { get; set; }
        public bool BitcoinBlockchainOperationsDisabled { get; set; }
        public bool BtcOperationsDisabled { get; set; }
    }
}
