using ASP.NetAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldAPIController : ControllerBase
    {

        private readonly ILogger<HelloWorldAPIController> _logger;

        public HelloWorldAPIController(ILogger<HelloWorldAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetData()
        {
            var data = new HelloWorld();
            data.Date = DateTime.Now;
            data.Value = "HelloWorld";
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            return jsonString;
        }

        [HttpPost]
        public string SetData(HelloWorld helloWorld)
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(helloWorld);
            return jsonString;
        }
    }
}
