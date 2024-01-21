using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.Write ("Welcome to the program.");
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
        string user_number = Console.ReadLine ();
        int favorite = int.Parse (user_number);
        return favorite;
    }
    static void Main(string[] args)
    {
       DisplayWelcome();
       PromptUserName();
       PromptUserNumber();
    }
}