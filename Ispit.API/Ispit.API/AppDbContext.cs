using Ispit.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API;

public class AppDbContext : DbContext
{
    public DbSet<ShoppingItem> ShoppingItems { get; set; }

    public AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=ShoppingItemsDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);
    }
}
