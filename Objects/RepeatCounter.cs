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
        int index = inputSentence.IndexOf(wordToMatch);
        int wordLength = wordToMatch.Length;
        int charsToRemove = index + wordLength;
        string truncatedString = inputSentence.Remove(0,charsToRemove) ;
        counter += CountOccurrences(truncatedString, wordToMatch);
      }
      return counter;
    }
  }

}
