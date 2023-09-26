using System;

namespace ScorerNamespace.Models
  {
    public class Scorer
    {
      public string Word { get; set; }

      public Scorer(string word)
      {
        Word = word;
      }

      public int DetermineScore()
      {
        string word = Word.ToLower();
        char[] wordArray = word.ToCharArray();
        int result = 0;
        foreach (char letter in wordArray)
        {
          switch (letter)
          {
            case 'a':
            case 'e': 
            case 'i': 
            case 'o':
            case 'u':
            case 'l':
            case 'n':
            case 'r':
            case 's':
            case 't':
              result += 1;
              break;
            case 'd': 
            case 'g':
              result += 2;
              break;
            case 'b': 
            case 'c':
            case 'm':
            case 'p':
              result += 3;
              break;
            case 'f': 
            case 'h': 
            case 'v':
            case 'w':
            case 'y':
              result += 4;
              break;
            case 'k':
              result += 5;
              break;
            case 'j': 
            case 'x':
              result += 8;
              break;
            case 'q': 
            case 'z':
              result += 10;
              break;
            default: 
            throw new Exception();
          }
        }
        return result;
      }
    }
  }