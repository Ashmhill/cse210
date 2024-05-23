using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor without parameters (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter (numerator/1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters (numerator/denominator)
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to get fraction string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to get decimal value
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
