class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();

    public ReflectingActivity(string activity, string startMessage) : base(activity, startMessage)
    {
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
    }

    public void Activity()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 3);
        
        Console.Write("Consider the following prompt:");
        Console.WriteLine($"\n --- {prompts[randomNumber]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. \n");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: 5");
        Thread.Sleep(1000);
        Console.Write("\b4");
        Thread.Sleep(1000);
        Console.Write("\b3");
        Thread.Sleep(1000);
        Console.Write("\b2");
        Thread.Sleep(1000);
        Console.Write("\b1");
        Thread.Sleep(1000);
        Console.Clear();
        
    }
}