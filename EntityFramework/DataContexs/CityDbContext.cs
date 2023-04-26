using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DataContexs;

internal class CityDbContext:DbContext
{
   public DbSet<City> Cities { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=B3-1\\SQLEXPRESS;Database=CityDb;Trusted_Connection=True;");
    }
}
