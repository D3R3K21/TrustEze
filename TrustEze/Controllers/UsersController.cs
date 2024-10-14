using Microsoft.AspNetCore.Mvc;
using TrustEze.Models;

namespace TrustEze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly List<UserDto> _users = new List<UserDto>
        {

            new UserDto { Name = "Austin", Id = new Guid("70e69143-e141-4e67-9b27-1c53c8dab1e5") },
            new UserDto { Name = "Britni", Id = new Guid("a1434c68-ffe5-4e1b-912d-dc195dc31e88")  },
            new UserDto { Name = "Derek", Id = new Guid("23e6c0d3-1e0d-4d7f-b1b0-fb805854d9c4") }
        };
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Users comment goes here
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<UserDto> Get()
        {
            return _users;
        }
    }
}