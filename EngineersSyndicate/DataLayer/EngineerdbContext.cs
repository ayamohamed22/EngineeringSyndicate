using EngineersSyndicate.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersSyndicate.DataLayer
{
    public class EngineerdbContext: DbContext
    {
        public EngineerdbContext(DbContextOptions<EngineerdbContext> options) : base(options)
        {

        }
        public DbSet<Engineers> Engineers { get; set; }
        public DbSet<Departments> Departments   { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Engineers_Projects> Engineers_Projects { get; set; }



    }
}
