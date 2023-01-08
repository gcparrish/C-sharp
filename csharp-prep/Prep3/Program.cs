using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string magicInput = Console.ReadLine();
        int magicNumber = int.Parse (magicInput);
        Console.Write("What is your guess?");
        string userGuess = Console.ReadLine();
        int guess = int.Parse (userGuess);
        if (guess > magicNumber)
        {
            Console.Write("Lower.");
        }
        else if (guess < magicNumber)
        {
            Console.Write("Higher.");
        }
        else
        {
            Console.Write("You got it!");
        }
    }
}