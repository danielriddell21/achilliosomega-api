using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AchilliosOmega.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversationController : ControllerBase
    {
        private readonly ILogger<ConversationController> _logger;

        public ConversationController(ILogger<ConversationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return string.Empty;
        }
    }
}
