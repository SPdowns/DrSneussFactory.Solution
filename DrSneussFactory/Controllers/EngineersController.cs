using Microsoft.AspNetCore.Mvc;
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
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
  }
}