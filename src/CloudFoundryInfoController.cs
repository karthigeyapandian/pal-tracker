using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class CloudFoundryInfoController : ControllerBase
    { 
	private readonly CloudFoundryInfo _message;
        

        [HttpGet]
        public CloudFoundryInfo SayHello() => _message;

        public CloudFoundryInfoController(CloudFoundryInfo message)
        {
            _message = message;
        }

    }
} 