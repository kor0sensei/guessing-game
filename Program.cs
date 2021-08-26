using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int GuessCount = 0;

            Console.WriteLine("Guess the Secret Number Bru");
            Console.WriteLine("Type a number between 1 and 100 and hit enter Bru");
            int guess = int.Parse(Console.ReadLine());
            while (GuessCount < 3)
            {
                if (guess == secretNumber) 
                {
                    Console.WriteLine("Ye Bru");
                    break;
                }
                else
                {
                    string HighLowString = "too high";
                    string GuessString = "guesses";
                    if ((4-GuessCount) == 1)
                    {
                        GuessString = "guess";
                    }
                    if (guess < secretNumber)
                    {
                        HighLowString = "too low";
                    }
                    GuessCount++;
                    Console.WriteLine($"Nah Bru {guess} is {HighLowString} Bru, You have {4-GuessCount} {GuessString} left Bru, Try again Bru");
                    guess = int.Parse(Console.ReadLine());
                }
            }
            if (guess != secretNumber)
            {
                Console.WriteLine("Nah Bru You Outta Guesses Bru");
            }
        }
    }
}