using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string user_first_name = Console.ReadLine();
        Console.Write("What is your Last name? ");
        string user_last_name = Console.ReadLine();

        Console.WriteLine($"\nYour name is {user_last_name}. {user_first_name} {user_last_name}.");
    }
}