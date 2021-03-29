using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfCore.EntityFramework
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
         
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                    new User { Id=1, Name="Tom", Age=23},
                    new User { Id=2, Name="Alice", Age=26},
                    new User { Id=3, Name="Sam", Age=28}
                });
        }
    }
}
