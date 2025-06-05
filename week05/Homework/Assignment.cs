using System.Dynamic;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }

    public void SetName(string name)
    {
        _studentName = name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"Student Name: {_studentName} \n Topic: {_topic}");
    }
}