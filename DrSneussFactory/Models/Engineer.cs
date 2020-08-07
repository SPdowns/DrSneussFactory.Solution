using System.Collections.Generic;
using System;

namespace DrSneussFactory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int JobTitle { get; set; }
    public ICollection<EngineerMachine> Machines { get; set; }
  }
}