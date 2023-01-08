using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next(1, 20);
        int guess;
        do
        {
            Console.Write("Guess a number between 1 and 20. ");
            string userGuess = Console.ReadLine();
            guess = int.Parse (userGuess);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        } while (guess != magicNumber);
    }
}