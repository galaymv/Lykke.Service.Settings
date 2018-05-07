using System;
using Lykke.Service.Settings.Core.Domain;
using Microsoft.WindowsAzure.Storage.Table;

namespace Lykke.Service.LykkeService.AzureRepositories.Entities.Exchange
{
    public class ExchangeSettingsEntity : TableEntity, IExchangeSettings 
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string ETag { get; set; }
        public string BaseAssetIos { get; }
        public string BaseAssetOther { get; }
        public bool SignOrder { get; }
    }
}
