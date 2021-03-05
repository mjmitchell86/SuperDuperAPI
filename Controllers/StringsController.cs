using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperDuperAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringsController : ControllerBase
    {

        private readonly ILogger<StringsController> _logger;

        public StringsController(ILogger<StringsController> logger)
        {
            _logger = logger;
        }
        [Route("allcaps")]
        [HttpGet]
        public String Get(string lowerCase)
        {
            string upperCase = lowerCase.ToUpper(); 
            return upperCase;
        }
    }
}
