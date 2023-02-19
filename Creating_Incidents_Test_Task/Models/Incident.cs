using System.ComponentModel.DataAnnotations;

namespace Creating_Incidents_Test_Task.Models
{
    public class Incident
    {
        [Key]
        public Guid IdName { get; set; }

        public string Description { get; set; }
    }
}
