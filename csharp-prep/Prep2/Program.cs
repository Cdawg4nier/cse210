using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage? ");
        string user_input = Console.ReadLine();

        int user_score = int.Parse(user_input);
        string letter_grade = "";
        bool pass = false;

        if (user_score >= 90)
        {
            letter_grade = "A";
            pass = true;
        }
        else if (user_score >= 80)
        {
            letter_grade = "B";
            pass = true;
        }
        else if (user_score >= 70)
        {
            letter_grade = "C";
            pass = true;
        }
        else if (user_score >= 60)
        {
            letter_grade = "D";
        }
        else if (user_score < 60)
        {
            letter_grade = "F";
        }

        Console.WriteLine($"With a score of {user_score}, your letter grade is: {letter_grade}");
        if (pass)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }
    }
}