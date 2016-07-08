using Nancy;
using System.Collections.Generic;
using System;
using RepeatCounter;

namespace RepeatCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {

        return View["index.cshtml"];
      };
      Post["/find"] = _ => {
        var counter = new Counter();
        string inputSentence =  Request.Form["searchPhrase"];
        string wordToMatch = Request.Form["word"];
        int result = counter.CountOccurrences(inputSentence, wordToMatch);
        return View["result.cshtml", counter];
      };
    }
  }
}
