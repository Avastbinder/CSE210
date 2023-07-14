using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Lecture lecture = new Lecture("Professor Grifith", "70", "Global Warming", "The effects of CO2 on our global climate", "7/14", "6:30 PM", "Lecture");
        Reception reception = new Reception("Please respond back to make sure you are put on the list.", "Brian and Mary's wedding", "You are invited to Brian's and Mary's wedding!", "9/13/2023", "3 PM", "Reception");
        Outdoor outdoorGathering = new Outdoor("Partly sunny", "High adventure meeting", "Plan our high adventure! Make sure to invite your friends!", "7/19", "6 PM", "Outdoor Gathering");

        lecture.SetAddress("2524 Oakbank Ct", "Saint Cloud", "Florida", "USA");
        reception.SetAddress("292nd Ave SE", "Ravensdale", "Washington", "USA");
        outdoorGathering.SetAddress("440 S 2nd W", "Rexburg", "Idaho", "USA");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        Console.Clear();
        Console.WriteLine("------------------------------------\n");

        foreach(Event eventt in events)
        {
            Console.WriteLine(eventt.GetEventType());
            Console.WriteLine("\n----------------");
            Console.WriteLine("Short description:\n");
            Console.WriteLine(eventt.GetShortDesc());
            Console.WriteLine("----------------");
            Console.WriteLine("Standard details:\n");
            Console.WriteLine(eventt.GetStandardDesc());
            Console.WriteLine("----------------");
            Console.WriteLine("Full details:\n");
            Console.WriteLine(eventt.GetFullDesc());
            Console.WriteLine("------------------------------------\n");
        }
    }
}