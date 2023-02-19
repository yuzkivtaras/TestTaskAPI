using Creating_Incidents_Test_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Creating_Incidents_Test_Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {           
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Incident> Incidents { get; set; }
    }
}
