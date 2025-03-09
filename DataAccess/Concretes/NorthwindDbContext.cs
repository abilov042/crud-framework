using Entity.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Dao.Concretes;

public class NorthwindDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Database=northwind; Username=postgres; Password=1234");
    }

    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}