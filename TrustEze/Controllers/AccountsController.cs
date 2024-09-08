using Microsoft.AspNetCore.Mvc;
using TrustEze.Models;

namespace TrustEze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly List<AccountDto> _accounts = new List<AccountDto>
        {

            new AccountDto { UserId = new Guid("70e69143-e141-4e67-9b27-1c53c8dab1e5"), Id = Guid.NewGuid() },
            new AccountDto {  UserId = new Guid("a1434c68-ffe5-4e1b-912d-dc195dc31e88"), Id = Guid.NewGuid()  },
            new AccountDto {  UserId = new Guid("23e6c0d3-1e0d-4d7f-b1b0-fb805854d9c4"), Id = Guid.NewGuid() }
        };
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Get Accounts comment goes here
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAccounts")]
        public IEnumerable<AccountDto> Get()
        {
            return _accounts;
        }
    }
}