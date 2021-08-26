using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int GuessCount = 0;
            int Difficulty = 0;

            Console.WriteLine("Guess the Secret Number Bru");
            Console.WriteLine("Enter a difficulty easy to hard 1 to 3 Bru");
            while(Difficulty == 0)
            {
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Difficulty = 1;
                        GuessCount = 8;
                        Console.WriteLine("Easy Bru, You have 8 guesses to find the secret number Bru");
                        break;

                    case 2:
                        Difficulty = 2;
                        GuessCount = 6;
                        Console.WriteLine("Medium Bru, You have 6 guesses to find the secret number Bru");
                        break;

                    case 3:
                        Difficulty = 3;
                        GuessCount = 4;
                        Console.WriteLine("Hard Bru, You have 4 guesses to find the secret number Bru");
                        break;

                    case 42069:
                        Difficulty = 42069;
                        GuessCount = 999;
                        Console.WriteLine("Imagine being a Dogwater cheater Bru");
                        break;

                    default:
                        Console.WriteLine("Enter a difficulty level easy to hard 1 to 3 Bru");
                        break;
                }
            }
            Console.WriteLine("Type a number between 1 and 100 and hit enter Bru");
            int guess = int.Parse(Console.ReadLine());
            while (GuessCount > 1)
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
                    if ((GuessCount) == 2)
                    {
                        GuessString = "guess";
                    }
                    if (guess < secretNumber)
                    {
                        HighLowString = "too low";
                    }
                    if (GuessCount != 1000)
                    {
                        GuessCount--;
                    }
                    Console.WriteLine($"Nah Bru {guess} is {HighLowString} Bru, You have {GuessCount} {GuessString} left Bru, Try again Bru");
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