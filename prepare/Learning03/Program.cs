using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(3);
        Fraction fraction3 = new Fraction(5, 6);

        Console.WriteLine("Enter a number for the numerator:  ");
        int top = int.Parse(Console.ReadLine());
        fraction3.SetTopNumber(top);

        Console.WriteLine("Enter a number for the denominator:  ");
        int bottom = int.Parse(Console.ReadLine());
        fraction3.SetBottomNumber(bottom);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        
    }
}