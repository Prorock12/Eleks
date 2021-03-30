using Microsoft.EntityFrameworkCore;
using ModelStandard.Models;

namespace WpfCore.EntityFramework
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Element> Elements { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        //public DbSet<Slide> Slides { get; set; }

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

            //modelBuilder.Entity<TextElement>()
            //    .HasData(new TextElement("Text")); 
            /*, new ImageElement("Image"), new VideoElement("Video"));*/


            //modelBuilder.Entity<Element>().ToTable("Element");

            modelBuilder.Entity<Presentation>().Ignore(c => c.Ques);
            modelBuilder.Entity<Presentation>().Ignore(c => c.Resolution);

            //modelBuilder.Entity<Element>().HasNoKey();
            //modelBuilder.Entity<TextElement>();
            //modelBuilder.Entity<Element>();

            //modelBuilder.Entity<VisualElement>().Ignore(c => c.Background);
            //modelBuilder.Entity<VisualElement>().Ignore(c => c.BorderBrush);
            //modelBuilder.Entity<VisualElement>().Ignore(c => c.Color);
            //modelBuilder.Entity<VisualElement>().Ignore(c => c.Margin);

            modelBuilder.Entity<Presentation>();
            modelBuilder.Entity<Presentation>().HasNoKey();
            modelBuilder.Entity<Presentation>().HasKey(x=>x.)

            modelBuilder.Entity<Presentation>().HasData(
                new Presentation[]
                {
                    new Presentation("FirstPresentation"),
                    new Presentation("SecondPresentation")
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
