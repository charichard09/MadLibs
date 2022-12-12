using MadlibVariables.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadlibVariables.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(string adjective, string food, string verb, string saying, string noun, string food2, string color, string ride, string animal, string person)
    {
      MadlibValues madlibVariables = new MadlibValues();

      madlibVariables.Adjective = adjective;
      madlibVariables.Foods = food;
      madlibVariables.Verb = verb;
      madlibVariables.Saying = saying;
      madlibVariables.Noun = noun;
      madlibVariables.Foods2 = food2;
      madlibVariables.Color = color;
      madlibVariables.Ride = ride;
      madlibVariables.Animal = animal;
      madlibVariables.Person = person;

      return View(madlibVariables);
    }
  }

  public class MadlibTheGymController : Controller
  {
    [Route("/MadlibTheGymForm")]
    public ActionResult FormTheGym() { return View(); }

    [Route("/MadlibTheGym")]
    public ActionResult MadlibTheGym(string familyName, string boyName, string girlName, string boyName2, string girlName2, string number, string equipment)
    {
      MadlibTheGymValues madlibTheGymValue = new MadlibTheGymValues();

      
      madlibTheGymValue.FamilyName = familyName;
      madlibTheGymValue.BoyName = boyName;
      madlibTheGymValue.GirlName = girlName;
      madlibTheGymValue.Boy2Name = boyName2;
      madlibTheGymValue.Girl2Name = girlName2;
      madlibTheGymValue.Number = number;
      madlibTheGymValue.Equipment = equipment;

      return View(madlibTheGymValue);
    }
  }
}