using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse (userInput);
        string letter = "" ;
        string symbol = "" ;
        if (grade >= 90)
        {
            letter = "n A" ;
            if (grade < 93)
            {
                symbol = "-" ;
            }
        }
        else if (grade >=80)
        {
            Console.WriteLine("You got a B.");
        }
        else if (grade >=70)
        {
            Console.WriteLine("You got a C.");
        }
        else if (grade >=60)
        {
            Console.WriteLine("You got a D.");
        }
        else      
        {
            Console.WriteLine("You got an F");
        }
        Console.WriteLine($"You got a{letter}{symbol}");
        if (grade >=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Why you such a failure!?");
        }
    }
}