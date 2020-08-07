using Microsoft.AspNetCore.Mvc;
using DrSneussFactory.Models;
using System.Collections.Generic;
using System.Linq;

namespace DrSneussFactory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly DrSneussFactoryContext _db;

    public MachinesController(DrSneussFactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }
  }
}