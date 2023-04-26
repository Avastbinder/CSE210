using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int number = randomgenerator.Next(1,100);
        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
            if (guess < number)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}