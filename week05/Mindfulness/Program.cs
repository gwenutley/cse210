using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a number from the menu:");
            string userInput = Console.ReadLine();
            int choice; 

            if (!int.TryParse(userInput, out choice)) 
            {
                Console.WriteLine("Please enter a valid number.");
                return; 
            }

            if (choice == 1)
            {
                Breathe breathing = new Breathe("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing.");
                breathing.RunBreathe();
            }
            else if (choice == 2)
            {
                Reflect reflecting = new Reflect("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                reflecting.RunReflect();
            }
            else if (choice == 3)
            {
                Listen listening = new Listen("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listening.RunListen();
            }
            else if (choice == 4)
            {
                break;
            }
        }
    }
}