using System.Threading.Tasks;

namespace Lykke.Service.Settings.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}
