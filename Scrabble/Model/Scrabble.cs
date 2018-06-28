using System;
using System.Collections.Generic;
namespace Scrabble
{
  public class ScrabbleScore
  {

    public string _userWord;
    public ScrabbleScore(string userWord)
    {
      _userWord = userWord;
    }
    Dictionary<string, int> ScrabbleDictionary = new Dictionary<string, int>(){{"A",1},{"E",1},{"I",1},{"O",1},{"U",1},{"L",1},{"N",1},{"R",1},
    {"S",1},{"T",1},{"D",2},{"G",2},{"B",3},{"C",3},{"M",3},{"P",3},{"F",4},
    {"H",4},{"V",4},{"W",4},{"Y",4},{"K",5},{"J",8},{"X",8},{"Q",10},{"Z",10}};

    public int wordScore()
    {
      string userWordUpper = _userWord.ToUpper();
      string test = "";
      int finalScore = 0;
      for (int index = 0; index < userWordUpper.Length; index++)
      {
        test = userWordUpper[index].ToString();
        finalScore += ScrabbleDictionary[test];
      }
      return finalScore;
    }
  }

  class ScrabbleGame
  {
    static void Main()
    {
      Console.WriteLine("Enter your word");
      string userWord = Console.ReadLine();
      Console.WriteLine(userWord);
      ScrabbleScore word = new ScrabbleScore(userWord);
      word.wordScore();
      Console.WriteLine(word.wordScore());
    }
  }
}
