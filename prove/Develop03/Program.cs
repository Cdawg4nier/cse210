using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // To exceed the expectations of the program, I have allowed the user to enter their own verse. This code is present here:
        string text = "";
        Reference reference;
        Console.WriteLine("Welcome to the scripture memorizer!");
        Console.WriteLine("Please type '1' if you would like to be given a scripture, or simply hit enter if you would like to add your own.");
        string userMenu = Console.ReadLine();
        string optionOne = "1";
        if (userMenu == optionOne)
        {
            reference = new Reference("James", "1", ["5"]);
            text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        }
        else
        {
            Console.WriteLine("What book is your scripture reference in? (e.g. John, Matthew, Alma): ");
            string userBook = Console.ReadLine();
            Console.WriteLine("Great! What Chapter is your reference from? ");
            string userChapter = Console.ReadLine();
            Console.WriteLine("Awesome! Now please tell us which verses you are trying to memorize (separate multiple verses with commas, such as 17, 18, 19, 20) ");
            string userVerses = Console.ReadLine();
            Console.WriteLine("Fantastic! Now finally, please give us the text for the scripture. ");
            text = Console.ReadLine();

            string[] verses = userVerses.Split(",");
            reference = new Reference (userBook, userChapter, verses);

        
        }
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine("\nLet us begin! Remember at any time, you can type 'quit' to exit. Continually press Enter to continue.");
        Console.ReadLine();

        do 
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }
            if (scripture.isCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have succesfully reached the end of the program. We hope it was helpful!");
                break;
            }
            Random rng = new Random();
            int numberToHide = rng.Next(1,3);
            scripture.HideRandomWords(numberToHide);
            

        } while (true);
    }
}