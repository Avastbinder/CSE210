class BreathingActivity : Activity
{
    public BreathingActivity(string activity, string startMessage) : base(activity, startMessage)
    {
    }

    public void Activity()
    {
        int i = 0;
        int totalActivities = ((_duration/3)+1)/2;
        
        while (i <= totalActivities)
        {
            Console.Write("\nBreath in...    ");
            Console.Write("\b3");
            Thread.Sleep(1000);
            Console.Write("\b2");
            Thread.Sleep(1000);
            Console.Write("\b1");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("\nBreath out...    ");
            Console.Write("\b3");
            Thread.Sleep(1000);
            Console.Write("\b2");
            Thread.Sleep(1000);
            Console.Write("\b1");
            Thread.Sleep(1000);
            Console.Clear();

            i+=1;
        }
        Console.WriteLine(GetEndMessage());
        Pause();
    }
}