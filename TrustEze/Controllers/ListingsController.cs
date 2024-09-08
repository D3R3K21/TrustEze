using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json;
using TrustEze.Models;
using TrustEze.Models.Api;

namespace TrustEze.Controllers
{
    /// <summary>
    /// Testing Summary Goes Here
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ListingsController : ControllerBase
    {
        private static readonly ListingResponse? _listingResponse;
        static ListingsController()
        {
            _listingResponse = new ListingResponse();
            Fakers.GetListingFaker().Populate(_listingResponse);

            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "TrustEze.listingSample.json";
            //using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream ?? throw new Exception("TrustEze.listingSample.json not found")))
            //{
            //    string result = reader.ReadToEnd();
            //    _listingResponse = JsonSerializer.Deserialize<ListingResponse>(result);
            //    if (_listingResponse == null)
            //    {
            //        throw new Exception("Error Deserializing 'TrustEze.listingSample.json'");
            //    }
            //}
        }

        private readonly ILogger<AccountsController> _logger;

        public ListingsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Get Listings comment goes here
        /// </summary>
        /// <returns>returns a thing</returns>
        [HttpGet(Name = "GetListings")]
        public ListingResponse Get()
        {
            return _listingResponse;
        }
    }
}