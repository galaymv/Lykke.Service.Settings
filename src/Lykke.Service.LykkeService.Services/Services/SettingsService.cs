using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Domain;
using Lykke.Service.Settings.Core.Repositories;
using Lykke.Service.Settings.Core.Services;

namespace Lykke.Service.Settings.Services.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly IExchangeSettingsRepository _exchangeSettingsRepository;
        private readonly IAppGlobalSettingsRepository _appGlobalSettingsRepository;

        public SettingsService(IExchangeSettingsRepository exchangeSettingsRepository, 
            IAppGlobalSettingsRepository appGlobalSettingsRepository)
        {
            _exchangeSettingsRepository = exchangeSettingsRepository;
            _appGlobalSettingsRepository = appGlobalSettingsRepository;
        }

        public Task<IExchangeSettings> GetExchangeSettingsAsync(string clientId)
        {
            return _exchangeSettingsRepository.GetFromDbOrDefaultAsync(clientId);
        }

        public Task<IAppGlobalSettings> GetAppGlobalSettingsSettingsAsync()
        {
            return _appGlobalSettingsRepository.GetFromDbOrDefault();
        }
    }
}
