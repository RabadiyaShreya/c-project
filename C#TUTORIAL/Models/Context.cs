using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using C__TUTORIAL.Models;

namespace C__TUTORIAL.Models
{
  public class Context : DbContext
  {
    public DbSet<registration> registration { get; set; }

    // public DbSet<Publisher> Publisher { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=c_tutorial;user='root';password=''");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<registration>(entity =>
      {        
        entity.HasKey(e => e.Username);
      
        entity.Property(e => e.Password).IsRequired();
        entity.Property(e => e.Email).IsRequired();


      });
    }
  }
}
