using System;

class Program
{
    static List<Goal> goals = new List<Goal>();

    public static void CreateGoal(string goalType)
    {
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("Give a small description: ");
        string goalDesc = Console.ReadLine();
        Console.WriteLine("How much is this goal worth? ");
        int pointWorth = int.Parse(Console.ReadLine());

        if (goalType == "Simple")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalType, goalName, goalDesc, pointWorth, false);
            goals.Add(simpleGoal);
        }

        if (goalType == "Eternal")
        {
            EternalGoal eternalGoal = new EternalGoal(goalType, goalName, goalDesc, pointWorth, false);
            goals.Add(eternalGoal);
        }

        if (goalType == "Checklist")
        {
            Console.WriteLine("Complete how many times for bonus? ");
            int amountOfTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("What will the bonus be? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalType, goalName, goalDesc, pointWorth, false, amountOfTimes, bonus);
            goals.Add(checklistGoal);
        }
    }

    static void Main(string[] args)
    {
        Console.Clear();
        string response = "";

        while (response != "6")
        {
            
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            response = Console.ReadLine() ?? String.Empty;
            switch (response)
            {
                case "1":
                    string response2 = "";
                    Console.WriteLine("Which type of goal would you like to create?\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n");
                    response2 = Console.ReadLine() ?? String.Empty;

                    switch (response2)
                    {
                        case "1":
                            CreateGoal("Simple");
                            break;
                        case "2":
                            CreateGoal("Eternal");
                            break;
                        case "3":
                            CreateGoal("Checklist");
                            break;
                    }
                    response2 = "";
                    break;
                case "2":
                    Console.WriteLine("My goals are:");
                    int i = 0;

                    foreach (Goal goal in goals)
                    {
                        i++;
                        
                        Console.WriteLine($"{i}. [{goal.GetComplete()}] {goal.GetGoalName()} ({goal.GetGoalDesc()}) {goal.GetListEnding()}");
                    

                        
                    }
                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":
                    Console.WriteLine("The goals are:");
                    i=0;

                    foreach (Goal goal in goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {goal.GetGoalName()}");
                    }

                    Console.WriteLine("Which goal did you accomplish? ");
                    int goalSelect = int.Parse(Console.ReadLine());

                    goals[goalSelect-1].
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}