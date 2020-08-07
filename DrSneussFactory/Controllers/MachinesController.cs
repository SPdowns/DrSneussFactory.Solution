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
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}