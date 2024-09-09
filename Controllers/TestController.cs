using Microsoft.AspNetCore.Mvc;

namespace NewRelicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var random = new Random().Next(0, 10);

            if(random > 8)
                throw new Exception($"Random {random} é maior do que 8.");

            return Ok();
        }
    }
}
