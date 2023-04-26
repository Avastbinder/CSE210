using System;

class Program
{
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
    static int SquaredNumber(int number)
    {
        int squaredValue = number * number;
        return squaredValue;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquaredNumber(number);
        DisplayResult(name, squaredNumber);
    }
}