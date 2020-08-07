using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DrSneussFactory.Models;
using System.Collections.Generic;
using System.Linq;

namespace DrSneussFactory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly DrSneussFactoryContext _db;

    public EngineersController(DrSneussFactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer, int MachineId)
    {
      _db.Engineers.Add(engineer);
      if (MachineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, EngineerId = engineer.EngineerId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }
  }
}