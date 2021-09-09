using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Dictionary_ContainsKeyValuePairs_True()
    {
      var Letters = new Dictionary<string, int>(){{"A", 1}, {"B", 3}};
       Assert.AreEqual(1 , Letters["A"] );
       Assert.AreEqual(3 , Letters["B"] );
    }
    [TestMethod]
    public void CalculateScore_AddsKeyValuePair_True()
    {
      string userInput = "Hello";
      Assert.AreEqual(8, calculateScore(userInput));
    }
  }
}