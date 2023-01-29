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
        numbers.Remove(0);
        int sum = 0;
        int maximum = 0;
        foreach(int num in numbers)
        {
            sum += num;
            if (num > maximum)
            {
                maximum = num;
            }
        }
        int average = sum / numbers.Count;
        
        Console.Write ("Your sum is ");
        Console.WriteLine (sum);
        Console.Write ("Your average is ");
        Console.WriteLine (average);
        Console.Write ("Your maximum is ");
        Console.WriteLine (maximum);
        /*foreach(int num in numbers)
        {
            Console.WriteLine (num);
        }*/
        
    }
}