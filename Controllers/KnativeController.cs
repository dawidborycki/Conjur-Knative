using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Conjur_Knative.Models;

namespace Conjur_Knative.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KnativeController : ControllerBase
    {        
        private readonly Options options;

        public KnativeController(Options options)
        {            
            this.options = options;
        }

[HttpGet]
public string Get()
{            
    return options.Secret ?? "No secret was provided";
}
    }
}
