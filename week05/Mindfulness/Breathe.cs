public class Breathe : Activity
{
    public Breathe(string name, string description)
    : base(name, description)
    {
    }

    public void RunBreathe()
    {
        StartActivity();

        int duration = _duration;
        while (duration > 0)
        {
            Console.WriteLine("Breath in...");
            Countdown(4);
            duration = duration - 4;
            if (duration <= 0) break;

            Console.WriteLine("Now breathe out...");
            Countdown(4);
            duration = duration - 4;

            Console.WriteLine();
        }
    }
}