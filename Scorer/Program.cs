using System;
using ScorerNamespace.Models;
using System.Collections.Generic;

namespace ScorerNamespace
{
  class Program
  {
    static void Main()
    {
      Scorer newScorer = new Scorer("scrabble3");
      newScorer.DetermineScore();
      
      // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      // Console.WriteLine("Welcome to the Scrabble Scorer app!");
      // Console.WriteLine("Enter a word:");
    }
  }
}