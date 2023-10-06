using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Category> Stylists { get; set; }
    public DbSet<Item> Clients { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}