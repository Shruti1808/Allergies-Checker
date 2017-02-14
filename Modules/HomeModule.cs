using Nancy;
using Allergies;
using System;
using System.Collections.Generic;

namespace Allergies
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
      Get["/results"] =_=> {
        int score = Request.Query["score"];
        AllergiesScore testAllergiesScore = new AllergiesScore();
        List<string> listAllergen =  testAllergiesScore.AllergenCheck(score);
        return View["results.cshtml", listAllergen];
      };
    }
  }
}
