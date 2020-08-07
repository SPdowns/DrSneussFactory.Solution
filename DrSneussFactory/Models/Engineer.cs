using System.Collections.Generic;

namespace DrSneussFactory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<Machine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int JobTitle { get; set; }
    public ICollection<EngineerMachine> Machines { get; set; }
  }
}