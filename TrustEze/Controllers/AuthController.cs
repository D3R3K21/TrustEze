using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;
using TrustEze.Models;

namespace TrustEze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<AuthController> _logger;
        private readonly AuthControllerOptions _options;

        public AuthController(ILogger<AuthController> logger, IHttpClientFactory httpClientFactory, IOptions<AuthControllerOptions> options)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _options = options.Value;
        }
        [HttpGet("")]
        public async Task<IActionResult> Auth([FromQuery] string code)
        {
            var headers = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("client_id", _options.ClientId),
                new KeyValuePair<string, string>("client_secret", _options.ClientSecret),
                new KeyValuePair<string, string>("code", code),
                new KeyValuePair<string, string>("redirect_uri", _options.CallbackUri),
            };
            var content = new FormUrlEncodedContent(headers);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _options.CognitoUri)
            {
                Content = content
            };
            httpRequestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var httpClient = _httpClientFactory.CreateClient();

            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var json = JsonSerializer.Deserialize<object>(await httpResponseMessage.Content.ReadAsStringAsync());
                return new RedirectResult(string.Format(_options.FrontendRedirectURI, json));
            }

            return new BadRequestResult();


        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return Redirect(_options.HostedUIUri);
        }
    }
}



//curl--location--request POST 'https://trusteze.auth.us-east-1.amazoncognito.com/oauth2/token' \
//--header 'Content-Type: application/x-www-form-urlencoded' \
//--data - urlencode 'code=CODE' \
//--data - urlencode 'grant_type=authorization_code' \
//--data - urlencode 'client_id=3gn8kb63bta2jmkjhcnhtnb4q0' \
//--data - urlencode 'client_secret=CLIENT_SECRET' \
//--data - urlencode 'redirect_uri=http://localhost:80/auth'