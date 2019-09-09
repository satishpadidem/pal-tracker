using Microsoft.AspNetCore.Mvc;
namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello() => _message.Message;
        public readonly WelcomeMessage _message; 
       
        public WelcomeController(WelcomeMessage welcomeMessage)
        {
            _message = welcomeMessage;
        }
    }
}
