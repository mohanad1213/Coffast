using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffast.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly ILogger<ValueController> _logger;

        public ValueController(ILogger<ValueController> logger)
        {
            _logger = logger;
        }


        public ActionResult<object> Do()
        {
            this._logger.LogInformation("you code is working file");
            return "Start Working";
        }
    }
}
