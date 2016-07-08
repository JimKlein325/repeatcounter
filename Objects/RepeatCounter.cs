using System;
using System.Collections.Generic;
using System.Text;


namespace RepeatCounter
{
  public class Counter
  {
    public Counter()
    {
    }

    public int CountOccurrences(string inputSentence, string wordToMatch)
    {
      int counter = 0;
      if (inputSentence.Contains(wordToMatch))
      {
        counter++;
      }
      return counter;
    }
  }

}
