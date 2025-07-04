using System;

public class Reflect : Activity
{
    private int ranNumPrompt;
    private int ranNumQuestion;
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Random random = new Random();
    public Reflect(string name, string description)
    : base(name, description)
    {
    }
    public string GetReflectPrompt()
    {
        int ranNumPrompt = random.Next(0, _prompts.Count);
        return _prompts[ranNumPrompt];
    }

    public string GetQuestions()
    {
        int ranNumQuestion = random.Next(0, _questions.Count);
        return _questions[ranNumQuestion];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts[ranNumPrompt]); 
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(_questions[ranNumQuestion]);
    }

    public void RunReflect()
    {
        StartActivity();

        int duration = _duration;
        while (duration > 0)
        {
            DisplayPrompt();
            Countdown(3);
            duration = duration - 3;
            if (duration <= 0) break;

            DisplayQuestion();
            Countdown(3);
            duration = duration - 3;

            Console.WriteLine();

            EndActivity();
        }
    }

}