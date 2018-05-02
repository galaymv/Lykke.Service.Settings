using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lykke.Service.LykkeService.Controllers
{
    public class ExchangeSettings : Controller
    {
        private readonly ISettingsService _settingsService;

        public ExchangeSettings(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        // GET
        public async Task<IActionResult> Index(string clientId)
        {
            var settings = await _settingsService.GetExchangeSettingsAsync(clientId);
            return Ok(settings);
        }
    }
}
