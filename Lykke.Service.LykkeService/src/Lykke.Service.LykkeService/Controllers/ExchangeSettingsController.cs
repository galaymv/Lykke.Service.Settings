using System.Net;
using System.Threading.Tasks;
using Lykke.Service.ClientAccount.Client.AutorestClient.Models;
using Lykke.Service.Settings.Core.Services;
using Lykke.Service.Settings.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lykke.Service.Settings.Controllers
{
    [Route("api/ExchangeSettings")]
    [Produces("application/json")]
    public class ExchangeSettingsController : Controller
    {
        private readonly ISettingsService _settingsService;

        /// <inheritdoc />
        public ExchangeSettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        [SwaggerOperation("ExchangeSettings")]
        [ProducesResponseType(typeof(ExchangeSettingsResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(string clientId)
        {
            var settings = new ExchangeSettingsResponse(await _settingsService.GetExchangeSettingsAsync(clientId));
            return Ok(settings);
        }
    }
}
