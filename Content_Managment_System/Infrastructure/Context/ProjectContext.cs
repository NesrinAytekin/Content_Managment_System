using Content_Managment_System.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Content_Managment_System.Infrastructure.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options) { }
     
        public DbSet<Page> Pages { get; set; }
    }
}
