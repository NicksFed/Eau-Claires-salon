using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Stylist> Stylist { get; set; }
    public DbSet<Client> Client { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}
