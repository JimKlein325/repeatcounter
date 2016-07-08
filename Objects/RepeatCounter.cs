using System;
using System.Collections.Generic;
using System.Text;


namespace RepeatCounter
{
  public class Counter
  {
    string _searchableString;
    public string SearchableString
    {
      get
      {
        return this._searchableString;
      }
      set
      {
        if(_searchableString == null) this._searchableString = value;
      }
    }

    public string SearchWord {get; set;}
    public string Occurrences {get;set;}

    public Counter()
    {
    }

    public int CountOccurrences(string inputSentence, string wordToMatch)
    {
      this.SearchableString = inputSentence;
      this.SearchWord = wordToMatch;

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
          counter += CountOccurrences(truncatedString, word);
        }
      }
      this.Occurrences = counter.ToString();
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
