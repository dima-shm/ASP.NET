using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persones { set; get; }

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
