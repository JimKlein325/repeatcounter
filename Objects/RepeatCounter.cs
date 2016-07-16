using System;
using System.Collections.Generic;
using System.Text;


namespace Repeat_Counter.Objects
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputSentence, string wordToMatch)
    {
      int counter = 0;
      string word = wordToMatch.ToLower();
      string sentence = inputSentence.ToLower();
      if (sentence.Contains(word))
      {
        int index = sentence.IndexOf(word);
        if (IsNotSubstring(sentence, word, index))
        {
          counter++;
          int wordLength = word.Length;
          int charsToRemove = index + wordLength;
          string truncatedString = sentence.Remove(0, charsToRemove);
          counter += CountRepeats(truncatedString, word);
        }
      }
      return counter;
    }

    private bool IsNotSubstring(string sentence, string word, int indexOfMatch)
    {
      char[] sentenceChars = sentence.ToCharArray();

      bool beginsLikeAWord = false;
      bool endsLikeAWord = false;

      if (indexOfMatch == 0)
      {
        beginsLikeAWord = true;
      }
      else
      {
        if (sentenceChars[indexOfMatch - 1] == ' ') beginsLikeAWord = true;

        int precedingCharIndex = indexOfMatch - 1;
        char[] puntuation = new char[] { '"', '\'', '(',  '-' };
        foreach (char c in puntuation)
        {
          char precedingChar = sentenceChars[precedingCharIndex];
          if (c == precedingChar)
          {
            beginsLikeAWord = true;
            break;
          }
        }
      }
      if (sentenceChars.Length == indexOfMatch + word.Length)
      {
        endsLikeAWord = true;
      }
      else
      {
        int subsequentCharIndex = indexOfMatch + word.Length;
        char[] puntuation = new char[] {' ', '.', ',', '"', '\'', '?', '!', '-', ')' };
        foreach (char c in puntuation)
        {
          char followingChar = sentenceChars[subsequentCharIndex];
          if (c == followingChar)
          {
            endsLikeAWord = true;
            break;
          }
        }
      }
      return beginsLikeAWord && endsLikeAWord;
    }
  }
}
