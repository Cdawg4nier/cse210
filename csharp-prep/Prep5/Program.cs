using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        DisplayResult(username, SquareNumber(userNumber));
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");   
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string user_number = Console.ReadLine();
        int user_number_as_int = int.Parse(user_number);
        return user_number_as_int;
    }
    static int SquareNumber(int num)
    {
        int num_squared = num * num;
        return num_squared;
    }

    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}