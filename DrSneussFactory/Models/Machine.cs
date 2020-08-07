using System.Collections.Generic;

namespace DrSneussFactory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public string MachineDescription { get; set; }
    public virtual ICollection<EngineerMachine> Engineers { get; set; }
  }
}