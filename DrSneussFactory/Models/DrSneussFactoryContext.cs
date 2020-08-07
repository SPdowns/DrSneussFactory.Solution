using Microsoft.EntityFrameworkCore;

namespace DrSneussFactory.Models
{
  public class DrSneussFactoryContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; } // 1:15pm removed virtual, expirmenting with how to load through proxies
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public DrSneussFactoryContext(DbContextOptions options) : base(options) {}
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
  }
}