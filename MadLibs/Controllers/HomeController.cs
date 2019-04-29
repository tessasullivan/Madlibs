using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/Madlibs")]
    // public string Madlibs() { return "Hello World"; }
    public ActionResult Madlibs(string adj1, string adj2) 
    {
        MadlibVariable myMadlibVar = new MadlibVariable();
        myMadlibVar.SetAdj1(adj1);
        myMadlibVar.SetAdj2(adj2);

        return View(myMadlibVar); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}