using Creating_Incidents_Test_Task.Data;
using Creating_Incidents_Test_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Creating_Incidents_Test_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(Account account)
        {
            _context.Add(account);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
