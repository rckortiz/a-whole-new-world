using System;

namespace a_whole_new_world
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var min = 1m;
      var max = 100m;
      var guess = false;

      while (!guess)
      {
        var pcGuess = Math.Floor((min + max) / 2);
        Console.WriteLine($"Is this your number {pcGuess}?");
        Console.WriteLine("If the number is higher type -- higher -- and press enter");
        Console.WriteLine("If the number is lower type out -- lower -- and press enter");
        Console.WriteLine("If this is your number type -- yes -- and press enter");
        var isCorrect = Console.ReadLine();
        if (isCorrect == "yes")
        {
          guess = true;
          Console.WriteLine("I guessed right!");
          Console.WriteLine("If you want to play again type --yes-- and press enter");
          Console.WriteLine("if you would not like to continue type -- no -- and press enter");
          var playAgaind = Console.ReadLine();

        }
        else if (isCorrect == "higher")
        {
          min = pcGuess;
        }

        else if (isCorrect == "lower")
        {
          max = pcGuess;
        }




      }


    }
  }
}

