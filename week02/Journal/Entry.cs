public class Entry
{
    public string _date;
    public string _randomPrompt;
    public string _textEntry;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _randomPrompt = prompt;
        _textEntry = text;
    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"{_date}: {_randomPrompt} : {_textEntry}");

    }

}