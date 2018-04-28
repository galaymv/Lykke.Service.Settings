using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.Settings.Core.Repositories
{
    public interface IExchangeSettingsRepository
    {
        Task<IExchangeSettings> GetFromDbOrDefaultAsync(string clientId);
        Task<IExchangeSettings> GetAsync(string clientId);
    }
}
