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
      List<Engineer> model = _db.Items.ToList();
      return View(model);
    }
  }
}