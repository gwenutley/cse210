using System;

public class Listen : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count;
    private List<string> _entries = new List<string>();
    private Random random = new Random();

    public Listen(string name, string description)
    : base(name, description)
    {

    }
    public string GetListenPrompt()
    {
        int ranNum = random.Next(0, _prompts.Count);
        return _prompts[ranNum];
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
        _count++;
    }

    public void RunListen()
    {
        StartActivity();

        string prompt = GetListenPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many resonses as you can.");
        Console.WriteLine($"Prompt: {prompt}");

        int duration = _duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                AddEntry(input);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items");
        EndActivity();
    }

}