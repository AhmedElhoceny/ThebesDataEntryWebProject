using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThebesDataEntryWebProject.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
    }
}
