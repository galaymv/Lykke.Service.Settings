using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Domain;

namespace Lykke.Service.Settings.Core.Repositories
{
    public interface IAppGlobalSettingsRepository
    {
        Task<IAppGlobalSettings> GetFromDbOrDefault();
    }
}
