using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        Journal userJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        do 
        {
            DisplayMenu();
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Entry newEntry = new Entry();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                newEntry._promptText = randomPrompt;

                Console.Write($"{randomPrompt}\n>");
                newEntry._entryText = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                newEntry._date = currentTime.ToShortDateString();
                
                userJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename for the journal you would like to load? ");
                string filename = Console.ReadLine();
                userJournal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is the filename? ");
                string userFileName = Console.ReadLine();
                userJournal.SaveToFile(userFileName);
            }
            else
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                break;
            }

        } while (true);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
}