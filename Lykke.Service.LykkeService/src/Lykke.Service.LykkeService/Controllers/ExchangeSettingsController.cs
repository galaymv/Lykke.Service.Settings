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
        [ProducesResponseType(typeof(IsAliveResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Get(string clientId)
        {
            var settings = new ExchangeSettingsResponse(await _settingsService.GetExchangeSettingsAsync(clientId));
            return Ok(settings);
        }
    }
}
