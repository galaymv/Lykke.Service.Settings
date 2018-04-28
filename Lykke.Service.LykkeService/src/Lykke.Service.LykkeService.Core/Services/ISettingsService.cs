using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.Settings.Core.Services
{
    public interface ISettingsService
    {
        Task<IExchangeSettings> GetExchangeSettingsAsync (string clientId);
        Task<IAppGlobalSettings> GetAppGlobalSettingsSettingsAsync();
    }
}
