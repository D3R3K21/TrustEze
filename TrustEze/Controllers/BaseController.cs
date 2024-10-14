using Microsoft.AspNetCore.Mvc;
using TrustEze.Models;

namespace TrustEze.Controllers
{
    [ApiController]
    [Route("/")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger<AccountsController> _logger;

        public BaseController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "RedirectSwagger")]
        //[Route("/")]
        public IActionResult Get()
        {
            return Redirect("http://api.trusteze.co/swagger/index.html");
        }
    }
}