using System;
using Microsoft.EntityFrameworkCore;
using ModelStandard.Models;

namespace WpfCore.EntityFramework
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<VisualElement> VisualElements { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Slide> Slides { get; set; }

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
            modelBuilder.Entity<VisualElement>().HasKey(x => x.Id);
            modelBuilder.Entity<VisualElement>().Ignore(x => x.Background);
            modelBuilder.Entity<VisualElement>().Ignore(x => x.BorderBrush);
            modelBuilder.Entity<VisualElement>().Ignore(x => x.Color);
            modelBuilder.Entity<VisualElement>().Ignore(x => x.Margin);
            modelBuilder.Entity<VisualElement>();
            //modelBuilder.Entity<VisualElement>().HasBaseType<VisualElement>();
            modelBuilder.Entity<VisualElement>().HasData(
                new VisualElement("First Element"),
                new VisualElement("Second Element") 
            );

            modelBuilder.Entity<Slide>().Ignore(x => x.Elements);
            modelBuilder.Entity<Slide>().HasKey(x => x.Id);
            modelBuilder.Entity<Slide>().HasData(
                new Slide("First Slide") {Id = Guid.NewGuid().ToString()},
                new Slide("Second Slide") {Id = Guid.NewGuid().ToString()}
            );

            modelBuilder.Entity<Presentation>().Ignore(c => c.Ques);
            modelBuilder.Entity<Presentation>().Ignore(c => c.Resolution);
            modelBuilder.Entity<Presentation>().HasKey(x => x.Id);
            modelBuilder.Entity<Presentation>().HasData(
                new Presentation {Id = Guid.NewGuid().ToString(), Path = "sss", Name = "First presentation"},
                new Presentation {Id = Guid.NewGuid().ToString(), Path = "aaa", Name = "Second presentation"}
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
