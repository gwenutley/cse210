public class Writing : Assignment
{
    private string _title;
    public Writing(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public void GetWrittingInfo()
    {
        Console.WriteLine($"'{_title}'");
    }
}