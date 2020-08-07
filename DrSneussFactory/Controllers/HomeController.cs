using Microsoft.AspNetCore.Mvc;

namespace DrSneussFactory.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}