using System;
using ScorerNamespace.Models;
using System.Collections.Generic;

namespace ScorerNamespace
{
  class Program
  {
    static void Main()
    {
      try
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("Welcome to the Scrabble Scorer app!");
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        Scorer newScorer = new Scorer(word);
        int result = newScorer.DetermineScore();
        Console.WriteLine($"The Scrabble score for this word is {result}.");
        Console.WriteLine("Score another word? (yes to score, any other input to exit)");
        string rerun = Console.ReadLine().ToLower();
        if (rerun == "yes")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye.");
        }
      }
      catch
      {
        Console.WriteLine("Word must only contain letters.");
        Main();
      }
    }
  }
}