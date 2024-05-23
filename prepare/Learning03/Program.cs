using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Displaying fraction and decimal values
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()} = {f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()} = {f4.GetDecimalValue()}");

        // Testing getters and setters
        f1.SetNumerator(2);
        f1.SetDenominator(5);
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");

        f2.SetNumerator(7);
        f2.SetDenominator(8);
        Console.WriteLine($"{f2.GetFractionString()} = {f2.GetDecimalValue()}");
    }
}