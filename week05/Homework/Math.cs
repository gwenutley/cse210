using System.Reflection.PortableExecutable;

public class Math : Assignment
{
    private string _bookSection;
    private string _problems;
    public Math(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _bookSection = section;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section: {_bookSection} Problems: {_problems}");
    }
}