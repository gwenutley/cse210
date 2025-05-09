using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        float userGuess = -1;
        while (userGuess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = float.Parse(guess);

            if (userGuess != magicNumber)
            {
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}