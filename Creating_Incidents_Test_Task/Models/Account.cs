using System.ComponentModel.DataAnnotations;

namespace Creating_Incidents_Test_Task.Models
{
    public class Account
    {
        [Key]
        public string Name { get; set; }

        public Contact Contact { get; set; }
    }
}
