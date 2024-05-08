using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(10);
        Fraction fraction3 = new Fraction(6,9);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine($"{fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

        fraction1.SetTop(2);
        fraction1.SetBottom(17);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine($"{fraction1.GetDecimalValue()}");

        Console.WriteLine($"{fraction2.GetTop()}");
        Console.WriteLine($"{fraction2.GetBottom()}");
    }
}