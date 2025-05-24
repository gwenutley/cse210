using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("Then, my brethren, ye shall reap the rewards of your faith, and your diligence, and patience, and long-suffering, waiting for the tree to bring forth fruit unto you.");

        string decision = "";

        while (decision.ToLower() != "quit")
        {
            Console.Clear(); // Optional: Clears the console for a cleaner look
            Console.WriteLine(scripture1.GetReference());
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            decision = Console.ReadLine();

            if (decision.ToLower() != "quit")
            {
                scripture1.HideRandom(2);
            }

            if (scripture1.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden!");
                break;
            }
        }



    }
}