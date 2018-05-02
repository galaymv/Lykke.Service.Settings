using System.Threading.Tasks;
using Lykke.Service.Settings.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lykke.Service.LykkeService.Controllers
{
    public class AppSettingsController : Controller
    {
        private readonly ISettingsService _settingsService;

        public AppSettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientAppSettings = await _settingsService.GetAppGlobalSettingsSettingsAsync();
            return Ok(clientAppSettings);
        }
    }
}
