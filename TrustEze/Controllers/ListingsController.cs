using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json;
using TrustEze.Models;
using TrustEze.Models.Api;

namespace TrustEze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingsController : ControllerBase
    {
        private static readonly Root? _listingResponse;
        static ListingsController()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "TrustEze.listingSample.json";
            using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream ?? throw new Exception("TrustEze.listingSample.json not found")))
            {
                string result = reader.ReadToEnd();
                _listingResponse = JsonSerializer.Deserialize<Root>(result);
                if (_listingResponse == null)
                {
                    throw new Exception("Error Deserializing 'TrustEze.listingSample.json'");
                }
            }
        }

        private readonly ILogger<AccountsController> _logger;

        public ListingsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetListings")]
        public Root Get()
        {
            return _listingResponse;
        }
    }
}