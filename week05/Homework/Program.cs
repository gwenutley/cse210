using System;

class Program
{
    static void Main(string[] args)
    {
        Math assignment1 = new Math("Sally", "Division", "7.0", "6-10");
        assignment1.GetSummary();
        assignment1.GetHomeworkList();
        Writing assignment2 = new Writing("Sally", "History", "Effects of the War");
        assignment2.GetSummary();
        assignment2.GetWrittingInfo();

    }
}