class Activity
{
    private string _activity;
    private string _startMessage;
    protected int _duration;
    public List<string> spinner = new List<string>();

    public Activity(string activity, string startMessage)
    {
        _activity = activity;
        _startMessage = startMessage;
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
    }

    public void DisplayTransScreen()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity} activity.\n{_startMessage}\n");
        Console.WriteLine("How much time in seconds do you wish to do this activity? ");
        string durString = Console.ReadLine();
        int duration = int.Parse(durString);
        SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause();
    }

    public void Pause()
    {
        int i = 0;
        int z = 0;

        while (i != 2)
        {
            while (z <= 3)
            {
                Console.Write(spinner[z]);
                Thread.Sleep(333);
                Console.Write("\b");
                z += 1;
            }
            z = 0;
            i += 1;
        }
        Console.Clear();
    }

    public string GetStartMessage()
    {
        return _startMessage;
    }

    public string GetEndMessage()
    {
        return $"Well Done!!\nYou have completed another {_duration} seconds of the {_activity} Activity.";
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}