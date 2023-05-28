using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Reference scriptureRef = new Reference("Proverbs", 3, 5, 6);
        Scripture proverbs = new Scripture(scriptureRef, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (response != "Q")
        {
            proverbs.Display();

            if ((proverbs.HiddenCheck()) == true)
            {
                break;
            }
            
            proverbs.HideRandom();
            Console.WriteLine("\nPress enter to continue, or Q to quit.");
        
            response = Console.ReadLine();
            response = response.ToUpper();

            Console.Clear();
        }
    }
}
