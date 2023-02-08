using Microsoft.EntityFrameworkCore;
using Repository.entities;
using Repository.repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public class Context: DbContext, Icontext
    {
     
        public DbSet<User> UserContext { get; set ; }
        public DbSet<Child> ChildsContext { get ; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localDb)\\msSQLlocalDb;Initial Catalog=practicumRacheli;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
    }

