using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EF_CodeFirst.Data;

public class EmployeeDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)   { }

    public EmployeeDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=true;");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Employee>()
            .HasIndex(x => new { x.Name })
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasData(
            new Employee { EmployeeId = 1, Name = "Stipan Ljudevit Drmić", Address = "Ilica 25, Zagreb", CompanyName = "Komunalac d.o.o.", Designation = "Profesionalni upravljač kamionom" },
            new Employee { EmployeeId = 2, Name = "Stipan", Address = "Ilica 26, Zagreb", CompanyName = "Komunalac d.o.o.", Designation = "Profesionalni upravljač kamionom" },
            new Employee { EmployeeId = 3, Name = "Ljudevit Drmić", Address = "Ilica 25, Zagreb", CompanyName = "Komunalac d.o.o.", Designation = "Profesionalni upravljač kamionom" },
            new Employee { EmployeeId = 4, Name = "Branko Radoš", Address = "Ščitarjevo 12" }
            );

        base.OnModelCreating(modelBuilder);
    }

}
