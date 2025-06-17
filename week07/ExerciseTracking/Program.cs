using System;

class Program
{
    static void Main(string[] args)
    {
        Run run1 = new Run("June 5", 30, 3);
        Console.WriteLine(run1.GetSummary());
        Swim swim1 = new Swim("June 15", 60, 15);
        Console.WriteLine(swim1.GetSummary());
        Bike bike1 = new Bike("June 25", 90, 20);
        Console.WriteLine(bike1.GetSummary());  
    }
}