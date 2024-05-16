using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine(@"Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you calm down by counting out seconds and allowing you to focus on your breathing.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else if (userInput == "2")
            {
                ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity is designed to help you reflect on past times in your life where you were strong, and to draw on that strength.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else if (userInput == "3")
            {
                ListeningActivity activity = new ListeningActivity("Listing", "This activity is designed to help you grasp how many blessings you have in your life by listing them.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else
            {
                break;
            }
        } while (true);
    }
}