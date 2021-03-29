using Models.Models;
using System.Data.Entity;

namespace Infrastructure.EntityFramework
{
    public class VisualElementContext : DbContext
    {
        public VisualElementContext() : base("DefaultConnection")
        {
            //Database.Create();
        }

        public DbSet<Element> Elements { get; set; }
    }
}