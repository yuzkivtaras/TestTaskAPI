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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Contact>().HasData(new Contact
        //    {
        //        FirstName = "Tommy",
        //        LastName = "Medina",
        //        Email = "tommy98@gmail.com",
        //    });

        //    modelBuilder.Entity<Contact>().HasData(new Contact
        //    {
        //        FirstName = "Jack",
        //        LastName = "Galloway",
        //        Email = "john28@gmail.com",
        //    });

        //    modelBuilder.Entity<Contact>().HasData(new Contact
        //    {
        //        FirstName = "Mary",
        //        LastName = "Smith",
        //        Email = "mary198@gmail.com",
        //    });
        //}
    }
}
