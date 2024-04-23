using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magic_number = randomGenerator.Next(1, 100);

        bool go_on = true;

        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
       do
       {
        Console.Write("What is your guess? ");
        string user_guess = Console.ReadLine();
        int guess_as_int = int.Parse(user_guess);

        if (guess_as_int == magic_number)
        {
            go_on = false;
            Console.WriteLine("Congratulations! You guessed the magic number! Thanks for playing!");
        }
        else if (guess_as_int < magic_number)
        {
            Console.WriteLine("That is incorrect! The magic number is higher than that!");
        }
        else if (guess_as_int > magic_number)
        {
            Console.WriteLine("That is incorrect! The magic number is lower than that!");
        }
       } while (go_on);
    }
}