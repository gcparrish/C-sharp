using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine ("Welcome to the program.");
    }
    static string PromptUserName ()
    {
        Console.WriteLine ("What is your name?");
        string user_name = Console.ReadLine();
        return user_name;
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine ("What is your favorite number?");
        string user_number = Console.ReadLine();
        int favorite = int.Parse (user_number);
        return favorite;
    }
    static int SquareUserNumber (int favorite)
    {
        int square = favorite*favorite;
        return square;
    }
    static void DisplayResult (string user_name,int square)
    {
        Console.WriteLine ($"Your name is: {user_name}");
        Console.WriteLine ($"Your favorite number squared is: {square}");
    }
    static void Main(string[] args)
    {
       DisplayWelcome();
       DisplayResult (PromptUserName(), SquareUserNumber(PromptUserNumber()));
    }
}