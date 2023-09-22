using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScorerNamespace.Models;

namespace ScorerTest.Tests
{
  [TestClass]
  public class ScorerTests
  {

    [TestMethod]
    public void ScorerConstructor_CreatesInstanceOfScorer_Scorer()
    {
      Scorer newScorer = new Scorer("scrabble");
      Assert.AreEqual(typeof(Scorer), newScorer.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "scrabble";
      Scorer newScorer = new Scorer(word);
      string result = newScorer.Word;
      Assert.AreEqual(word, result);
    }
  }
}