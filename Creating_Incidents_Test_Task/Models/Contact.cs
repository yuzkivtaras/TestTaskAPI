using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Creating_Incidents_Test_Task.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string Email { get; set; }
    }
}
