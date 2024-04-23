using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
            numbers.Add(int.Parse(input));
        } while (true);

        int max = 0;
        int sum = 0;
        float average = 0;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        average = sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}