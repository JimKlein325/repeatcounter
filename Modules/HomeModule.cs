using Nancy;
using System.Collections.Generic;
using System;
using Repeat_Counter.Objects;

namespace Repeat_Counter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      
      Post["/find"] = _ => {
        var repeatCounter = new RepeatCounter();
        string inputSentence =  Request.Form["searchPhrase"];
        string wordToMatch = Request.Form["word"];
        int result = repeatCounter.CountRepeats(inputSentence, wordToMatch);
        return View["result.cshtml", repeatCounter];
      };
    }
  }
}
