using System;
using System.Collections.Generic;

namespace ScorerNamespace.Models
  {
    public class Scorer
    {
      public string Word { get; set; }

      public Scorer(string word)
      {
        Word = word;
      }
    }
  }