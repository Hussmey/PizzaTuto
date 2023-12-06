using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaTuto.Data;

namespace PizzaTuto.DbContext

{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

   public AppDbContext(DbContextOptions options) : base(options)
    {
    }

         public DbSet<PizzaSpecial> PizzaSpecials { get; set; }

             protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity types here
    }
        
    }
}