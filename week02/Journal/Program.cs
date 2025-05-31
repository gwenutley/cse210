using System;
using System.Formats.Asn1;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please choose one of the following.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);


            if (choice == 1)
            {
                Console.WriteLine("Today's date : ");
                string _date = Console.ReadLine();

                string _prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {_prompt}");

                Console.WriteLine("Response: ");
                string _textEntry = Console.ReadLine();

                Entry newEntry = new Entry(_date, _prompt, _textEntry);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                journal.LoadFromFile();
                Console.WriteLine("Successfully Loaded.");
                journal.DisplayAll();
            }
            else if (choice == 4)
            {
                journal.SaveToFile();
                Console.WriteLine("Successfully saved.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Finished.");
            }
            else
            {
                Console.WriteLine("Invalid entry, please try again.");
            }
            Console.WriteLine();
        }
        
    }
}