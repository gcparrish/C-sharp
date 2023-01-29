using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number;
        do
        {
            Console.Write ("Enter a number: ");
            string listEntry = Console.ReadLine ();
            number = int.Parse (listEntry);
            numbers.Add(number);
        } while (number != 0);
        int total = 9;
        int average = total / numbers.Count;
        int maximum = 7;
        Console.Write ("Your total is ");
        Console.WriteLine (total);
        Console.Write ("Your average is ");
        Console.WriteLine (average);
        Console.Write ("Your maximum is ");
        Console.WriteLine (maximum);
    }
}