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
    public void TestWord()
    {

      ScrabbleScore word = new ScrabbleScore("A");

      Assert.AreEqual(1, word.returnFinalScore());
    }


  }



}
