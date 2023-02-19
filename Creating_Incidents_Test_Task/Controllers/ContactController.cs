using Creating_Incidents_Test_Task.Data;
using Creating_Incidents_Test_Task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Creating_Incidents_Test_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            var existingContact = _context.Contacts.FirstOrDefault(c => c.Email == contact.Email);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
            }
            else
            {
                _context.Add(contact);
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
