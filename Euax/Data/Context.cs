using Euax.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euax.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
