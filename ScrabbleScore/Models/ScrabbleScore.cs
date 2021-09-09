using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    Dictionary<string, int> Letters = new Dictionary<string, int>() 
    { {"A", 1}, {"B", 3} ,{"C" , 3} , {"D" , 2} , {"E", 1}, {"F", 4}, 
      {"G" , 2} , {"H", 4} , {"I", 1}, {"J", 8} , {"K", 5} , {"L", 1},
      {"M", 3}, {"N", 1}, {"O" , 1}, {"P", 3}, {"Q", 10}, {"R", 1},
      {"S", 1}, {"T", 1}, {"U", 1}, {"V", 4}, {"W", 4}, {"X", 8},
      {"Y", 4}, {"Z", 10}
    };

    public string Word {get; set;}

    public Scrabble(string word){
      Word = word;
    }
     public int CalculateScore(string userInput)
     {
      
      // int score = 0;
       string capitalUserInput = userInput.ToUpper();
       
       Console.WriteLine(capitalUserInput);
      for(int i = 0; i < capitalUserInput.Length; i++)
      {
        if(Letters.Contains(i)){
        // Console.WriteLine(Letters.ElementAt(j).Value);
         score += Int32.Parse(Letters[i]);
         return score;  
        }
        else{
           return 0;
        }
      }
      }
      
     
     }

  }
