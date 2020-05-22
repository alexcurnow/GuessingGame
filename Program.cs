using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            int guessesGiven = 0;

            Console.WriteLine("Select a difficulty: easy (8 attempts), medium (6 attempts), or hard (4 attempts).");
            string difficulty = Console.ReadLine();

            if (difficulty == "easy")
            {
                while (guessesGiven < 8)
                {
                    Console.WriteLine($"Hey... guess this secret number I'm thinking of between 1-100. Your guess ({guessesGiven + 1})");
                    string userGuess = Console.ReadLine();
                    int userGuessInt = int.Parse(userGuess);
                    if (userGuessInt == secretNumber)
                    {
                        Console.WriteLine("Success! You Guessed it!");
                        break;
                    }
                    else if (userGuessInt < secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too low!");

                    }
                    else
                    {
                        Console.WriteLine("Nope! Your number was too high.");
                    }
                    guessesGiven++;
                }
            }
            else if (difficulty == "medium")
            {
                while (guessesGiven < 6)
                {
                    Console.WriteLine($"Hey... guess this secret number I'm thinking of between 1-100. Your guess ({guessesGiven + 1})");
                    string userGuess = Console.ReadLine();
                    int userGuessInt = int.Parse(userGuess);
                    if (userGuessInt == secretNumber)
                    {
                        Console.WriteLine("Success! You Guessed it!");
                        break;
                    }
                    else if (userGuessInt < secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too low!");

                    }
                    else
                    {
                        Console.WriteLine("Nope! Your number was too high.");
                    }
                    guessesGiven++;
                }
            }
            else if (difficulty == "hard")
            {
                while (guessesGiven < 4)
                {
                    Console.WriteLine($"Hey... guess this secret number I'm thinking of between 1-100. Your guess ({guessesGiven + 1})");
                    string userGuess = Console.ReadLine();
                    int userGuessInt = int.Parse(userGuess);
                    if (userGuessInt == secretNumber)
                    {
                        Console.WriteLine("Success! You Guessed it!");
                        break;
                    }
                    else if (userGuessInt < secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too low!");

                    }
                    else
                    {
                        Console.WriteLine("Nope! Your number was too high.");
                    }
                    guessesGiven++;
                }
            }
            else if (difficulty == "cheater")
            {
                while (guessesGiven >= 0)
                {
                    Console.WriteLine($"Hey... guess this secret number I'm thinking of between 1-100. Your guess ({guessesGiven + 1})");
                    string userGuess = Console.ReadLine();
                    int userGuessInt = int.Parse(userGuess);
                    if (userGuessInt == secretNumber)
                    {
                        Console.WriteLine("Success! You Guessed it!");
                        break;
                    }
                    else if (userGuessInt < secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too low!");

                    }
                    else
                    {
                        Console.WriteLine("Nope! Your number was too high.");
                    }
                    guessesGiven++;
                }
            }

            while (guessesGiven < 4)
            {
                Console.WriteLine($"Hey... guess this secret number I'm thinking of between 1-100. Your guess ({guessesGiven + 1})");
                string userGuess = Console.ReadLine();
                int userGuessInt = int.Parse(userGuess);
                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Success! You Guessed it!");
                    break;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope! Your guess was too low!");

                }
                else
                {
                    Console.WriteLine("Nope! Your number was too high.");
                }
                guessesGiven++;
            }

        }
    }
}