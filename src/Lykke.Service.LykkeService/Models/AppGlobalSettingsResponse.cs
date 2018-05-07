using System;
using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.Settings.Models
{
    public class AppGlobalSettingsResponse : IAppGlobalSettings
    {
        public string DepositUrl { get; }
        public bool DebugMode { get; }
        public string DefaultIosAssetGroup { get; set; }
        public string DefaultAssetGroupForOther { get; set; }
        public bool IsOnReview { get; }
        public double? MinVersionOnReview { get; }
        public double IcoLkkSold { get; }
        public bool IsOnMaintenance { get; }
        public int LowCashOutTimeoutMins { get; }
        public int LowCashOutLimit { get; }
        public bool MarginTradingEnabled { get; }
        public bool CashOutBlocked { get; }
        public bool BtcOperationsDisabled { get; }
        public bool BitcoinBlockchainOperationsDisabled { get; }
        public bool LimitOrdersEnabled { get; }
        public double MarketOrderPriceDeviation { get; }
        public string[] BlockedAssetPairs { get; set; }
        public string OnReviewAssetConditionLayer { get; set; }
        public DateTime? IcoStartDtForWhitelisted { get; set; }
        public DateTime? IcoStartDt { get; set; }
        public bool ShowIcoBanner { get; set; }

        public AppGlobalSettingsResponse(IAppGlobalSettings settings)
        {
            DepositUrl = settings.DepositUrl;
            DebugMode = settings.DebugMode;
            DefaultIosAssetGroup = settings.DefaultIosAssetGroup;
            DefaultAssetGroupForOther = settings.DefaultAssetGroupForOther;
            IsOnReview = settings.IsOnReview;
            MinVersionOnReview = settings.MinVersionOnReview;
            IcoLkkSold = settings.IcoLkkSold;
            IsOnMaintenance = settings.IsOnMaintenance;
            LowCashOutTimeoutMins = settings.LowCashOutTimeoutMins;
            LowCashOutLimit = settings.LowCashOutLimit;
            MarginTradingEnabled = settings.MarginTradingEnabled;
            CashOutBlocked = settings.CashOutBlocked;
            BtcOperationsDisabled = settings.BtcOperationsDisabled;
            BitcoinBlockchainOperationsDisabled = settings.BitcoinBlockchainOperationsDisabled;
            LimitOrdersEnabled = settings.LimitOrdersEnabled;
            MarketOrderPriceDeviation = settings.MarketOrderPriceDeviation;
            BlockedAssetPairs = settings.BlockedAssetPairs;
            OnReviewAssetConditionLayer = settings.OnReviewAssetConditionLayer;
            IcoStartDtForWhitelisted = settings.IcoStartDtForWhitelisted;
            IcoStartDt = settings.IcoStartDt;
            ShowIcoBanner = settings.ShowIcoBanner;
        }
    }
}
