using Microsoft.AspNetCore.Mvc;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}