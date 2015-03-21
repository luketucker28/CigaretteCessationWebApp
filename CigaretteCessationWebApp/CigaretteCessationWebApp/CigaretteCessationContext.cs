using CigaretteCessationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CigaretteCessationWebApp
{
    public class CigaretteCessationContext : DbContext
  
{

        public DbSet<Target> Targets { get; set; }
        public DbSet<Consumed> Consumeds { get; set; }
        
    }
}