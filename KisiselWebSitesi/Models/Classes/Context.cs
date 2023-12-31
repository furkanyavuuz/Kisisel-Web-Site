using System.Data.Entity;

namespace KisiselWebSitesi.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Icons> Icons { get; set; }

    }
}