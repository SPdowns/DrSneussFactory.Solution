using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DrSneussFactory.Models
{
  public class DrSneussFactoryContextFactory : IDesignTimeDbContextFactory<DrSneussFactoryContext>
  {

    DrSneussFactoryContext IDesignTimeDbContextFactory<DrSneussFactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<RegistrarContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new DrSneussFactoryContext(builder.Options);
    }
  }
}