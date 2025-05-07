using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentInput = Console.ReadLine();
        float gradePercent = float.Parse(gradePercentInput);

        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else if (gradePercent < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid: please try again");
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congrats! You Passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time.");
        }



    }
}