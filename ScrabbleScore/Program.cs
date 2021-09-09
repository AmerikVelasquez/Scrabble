using System;
using System.Collections.Generic;
using ScrabbleScore.Models;


namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
       Console.WriteLine("Enter a word");
      string ScrabbleWord = Console.ReadLine();
      Scrabble scrabble = new Scrabble(ScrabbleWord);
      Console.WriteLine(scrabble.CalculateScore(ScrabbleWord));
    }
  }
}    
