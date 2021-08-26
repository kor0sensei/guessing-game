using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int GuessCount = 0;
            int DifficultyLevel = 0;

            Console.WriteLine("Guess the Secret Number Bru");
            Console.WriteLine("Please enter a difficulty level between 1 and 3:");
            while(DifficultyLevel == 0)
            {
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        DifficultyLevel = 1;
                        GuessCount = 8;
                        Console.WriteLine("Difficulty set to 'easy.' You have eight guesses to find the secret number.");
                        break;

                    case 2:
                        DifficultyLevel = 2;
                        GuessCount = 6;
                        Console.WriteLine("Difficulty set to 'medium.' You have six guesses to find the secret number.");
                        break;

                    case 3:
                        DifficultyLevel = 3;
                        GuessCount = 4;
                        Console.WriteLine("Difficulty set to 'hard.' You have four guesses to find the secret number.");
                        break;

                    default:
                        Console.WriteLine("You must enter a number between 1 and 3 to continue:");
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
                    GuessCount--;
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