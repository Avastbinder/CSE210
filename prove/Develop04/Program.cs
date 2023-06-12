using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string response = "";
        
        while (response != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu options:\n  1. Breathing activity\n  2. Reflecting activity\n  3. Listing activity\n  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            response = Console.ReadLine() ?? String.Empty;
            switch (response)
            {
                case "1":
                    breathingActivity.DisplayTransScreen();
                    breathingActivity.Activity();
                    break;
                case "2":
                    reflectingActivity.DisplayTransScreen();
                    reflectingActivity.Activity();
                    break;
                case "3":
                    listingActivity.DisplayTransScreen();
                    listingActivity.Activity();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }

            response = "";
        }
    }
}