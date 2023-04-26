using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}