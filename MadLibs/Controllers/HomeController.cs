using MadlibVariables.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(params string[] list)
    {
      MadlibVariable madlibVariables = new MadlibVariable();

      madlibVariables.Adjective = list[0];
      madlibVariables.Foods = list[1];
      madlibVariables.Verb = list[2];
      madlibVariables.Saying = list[3];
      madlibVariables.Noun = list[4];
      madlibVariables.Foods2 = list[5];
      madlibVariables.Color = list[6];
      madlibVariables.Ride = list[7];
      madlibVariables.Animal = list[8];
      madlibVariables.Person = list[9];

      return View(madlibVariables);
    }

  }
}