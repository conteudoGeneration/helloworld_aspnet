using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {

        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

    }

}
