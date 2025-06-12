public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine();

        Console.Write("Please enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Countdown(3);

    }

    public int GetDuration()
    {
        return _duration;
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Countdown(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Countdown(3);
    }

    public void Countdown(int seconds)
    {
        Console.WriteLine();
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

