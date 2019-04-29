using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/Madlibs")]
    public ActionResult Madlibs(string adj1, string adj2, string adj3, string adj4, 
    string adj5, string adj6, string adj7, string adj8, string noun1, string noun2, string verb1,
    string object1, string bodypart1, string bodypart2) 
    {
        MadlibVariable myMadlibVar = new MadlibVariable();
        myMadlibVar.SetAdj1(adj1);
        myMadlibVar.SetAdj2(adj2);
        myMadlibVar.SetAdj3(adj3);
        myMadlibVar.SetAdj4(adj4);
        myMadlibVar.SetAdj5(adj5);
        myMadlibVar.SetAdj6(adj6);
        myMadlibVar.SetAdj7(adj7);
        myMadlibVar.SetAdj8(adj8);
        myMadlibVar.SetNoun1(noun1);
        myMadlibVar.SetNoun2(noun2); 
        myMadlibVar.SetVerb1(verb1);
        myMadlibVar.SetObject1(object1);
        myMadlibVar.SetBodyPart1(bodypart1);
        myMadlibVar.SetBodyPart2(bodypart2);     
        return View(myMadlibVar); 
    }

    [Route("/")]
    public ActionResult Form() { return View(); }
  }
}