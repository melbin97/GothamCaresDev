using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using GothamCares.Entities;
namespace GothamCares.DAL.DataContext
{
    public class DatabaseContext:DbContext
    {
        //DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=localhost;Database=Gotham.dev;Username=melbin;Password=1997");
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
