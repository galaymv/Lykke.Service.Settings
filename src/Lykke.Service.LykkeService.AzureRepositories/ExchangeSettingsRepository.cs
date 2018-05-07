using System.Threading.Tasks;
using AzureStorage;
using Lykke.Service.LykkeService.AzureRepositories.Entities.Exchange;
using Lykke.Service.Settings.Core.Domain;
using Lykke.Service.Settings.Core.Repositories;

namespace Lykke.Service.LykkeService.AzureRepositories
{
    public class ExchangeSettingsRepository : IExchangeSettingsRepository
    {
        public string GeneratePartitionKey() => "ExchngSettings";
        public string GenerateRowKey(string clientId) => clientId;

        private readonly IExchangeSettings _defaultExchangeSettings;
        private readonly INoSQLTableStorage<ExchangeSettingsEntity> _tableStorage;
        
        public ExchangeSettingsRepository(INoSQLTableStorage<ExchangeSettingsEntity> tableStorage, IExchangeSettings defaultExchangeSettings)
        {
            _tableStorage = tableStorage;
            _defaultExchangeSettings = defaultExchangeSettings;
        }

        public async Task<IExchangeSettings> GetFromDbOrDefaultAsync(string clientId)
        {
            return await GetAsync(clientId) ?? _defaultExchangeSettings;
        }

        public async Task<IExchangeSettings> GetAsync(string clientId)
        {
            var partitionKey = GeneratePartitionKey();
            var rowKey = GenerateRowKey(clientId);
            return await _tableStorage.GetDataAsync(partitionKey, rowKey);
        }
    }
}
