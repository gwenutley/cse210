using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squared = SquareNumber(number);
        DisplayResult(squared, name);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite whole number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(int square, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}