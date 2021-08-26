using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can You Guess The Secret Number Bru?");
            Console.Write("What's Your Guess Bru? ");
            string guess = Console.ReadLine();
            int parsedGuess = int.Parse(guess);
            int secretNumber = 666;
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (parsedGuess != secretNumber && !outOfGuesses)
            {

                if (guessCount < guessLimit) 
                {
                Console.WriteLine("Try Again Bru");
                int guessesLeft = guessLimit - guessCount;
                Console.Write($"You Have {guessesLeft} Guesses Left Bru, What's Your Guess Bru?");
                parsedGuess = int.Parse(Console.ReadLine());
                guessCount++; 
                }

                else
                {
                outOfGuesses = true;
                }
                
                if (outOfGuesses)
                {
                Console.WriteLine("Nah Bru You Outta Guesses Bru");
                }

                else 
                { 
                Console.WriteLine("Ye Bru");
                }
            }
        }
    }
}