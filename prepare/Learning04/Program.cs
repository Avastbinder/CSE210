using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{assignment1.GetSummary()}\n");

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{mathAssignment1.GetHomeworkList()}\n");

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Heather Scott");
        Console.WriteLine($"{writingAssignment1.GetWritingInfo()}");
    }
}