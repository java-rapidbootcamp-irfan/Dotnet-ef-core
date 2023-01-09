using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ef_db;uid=root;pwd=98M@null@n9;");
        }

        public DbSet<CategoryEntity> categories { get; set; }
    }
}