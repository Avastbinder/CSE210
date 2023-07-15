using System;

class Program
{
    static void Main(string[] args)
    {
        List<Excercise> activities = new List<Excercise>();
        Running running = new Running("Running", "7/15/23", 30, 3);
        Cycling cycling = new Cycling("Cycling", "7/2/23", 28, 20);
        Swimming swimming = new Swimming("Swimming", "7/9/23", 22, 11);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.Clear();
        Console.WriteLine("--------------");
        foreach (Excercise excercise in activities)
        {
            Console.WriteLine(excercise.GetSummary());
            Console.WriteLine("--------------");
        }
    }
}