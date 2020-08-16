using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; } // 1:15pm removed virtual, expirmenting with how to load through proxies
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) {}
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
  }
}