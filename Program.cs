using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can You Guess The Secret Number?");
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            Console.WriteLine($"Your guess is: {guess}");
            int parsedGuess = int.Parse(guess);
            int secretNumber = 666;

            if (parsedGuess == secretNumber)
            {
                Console.WriteLine("Ye Bru");
            }
            else
            {
                Console.WriteLine("Nah Bru");
            }
        }
    }
}