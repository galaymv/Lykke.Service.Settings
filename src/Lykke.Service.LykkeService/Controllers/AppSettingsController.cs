using System.Net;
using System.Threading.Tasks;
using Lykke.Service.ClientAccount.Client.AutorestClient.Models;
using Lykke.Service.Settings.Core.Services;
using Lykke.Service.Settings.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lykke.Service.Settings.Controllers
{
    [Route("api/AppSettings")]
    [Produces("application/json")]
    public class AppGlobalSettingsController : Controller
    {
        private readonly ISettingsService _settingsService;

        public AppGlobalSettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        [SwaggerOperation("AppSettings")]
        [ProducesResponseType(typeof(AppGlobalSettingsResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var clientAppSettings = new AppGlobalSettingsResponse(await _settingsService.GetAppGlobalSettingsSettingsAsync());
            return Ok(clientAppSettings);
        }
    }
}
