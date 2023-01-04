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
            letter = " B" ;
            if (grade >= 87)
            {
                symbol = "+" ;
            }
            else if (grade < 83)
            {
                symbol = "-" ;
            }
        }
        else if (grade >=70)
        {
            letter = " C" ;
            if (grade >= 77)
            {
                symbol = "+" ;
            }
            else if (grade < 73)
            {
                symbol = "-" ;
            }
        }
        else if (grade >=60)
        {
            letter = " D" ;
            if (grade >= 67)
            {
                symbol = "+" ;
            }
            else if (grade < 63)
            {
                symbol = "-" ;
            }
        }
        else      
        {
            letter = "n F" ;
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