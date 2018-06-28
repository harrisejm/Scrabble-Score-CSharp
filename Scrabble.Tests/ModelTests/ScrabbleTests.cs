using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

using Scrabble;
namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void wordScore()
    {
      ScrabbleScore word = new ScrabbleScore("AAA");
      Assert.AreEqual(3, word.wordScore());
    }
  }
}
