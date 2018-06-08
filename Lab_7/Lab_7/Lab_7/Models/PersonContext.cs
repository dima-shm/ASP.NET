using System.Data.Entity;

namespace Lab_7.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}