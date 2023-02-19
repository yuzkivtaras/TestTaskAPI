using Creating_Incidents_Test_Task.Data;
using Creating_Incidents_Test_Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Creating_Incidents_Test_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IncidentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncident(string name, string description, string email, string firstName, string lastName)
        {
            var account = await _context.Accounts.FindAsync(name);
            if (account == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Email == email);
            if (contact == null)
            {
                contact = new Contact
                {
                    FirstName = "",
                    LastName = "",
                    Email = email
                };
            }

            contact.Email = email;

            if (!string.IsNullOrEmpty(firstName))
            {
                contact.FirstName = firstName;
            }
            if (!string.IsNullOrEmpty(lastName))
            {
                contact.LastName = lastName;
            }

            account.Contact = contact;

            await _context.SaveChangesAsync();

            var incident = new Incident
            {
                Description = description
            };

            _context.Incidents.Add(incident);

            await _context.SaveChangesAsync();

            return Ok(incident);
        }
    }
}
