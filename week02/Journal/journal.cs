
using System.IO;
using Microsoft.VisualBasic;
public class Journal
{

    public List<Entry> _journalEntries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _journalEntries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _journalEntries)
        {
            entry.DisplayEntryDetails(); 
        }
    }

    public void SaveToFile()
    {
        string filename = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(var entry in _journalEntries)
            {
                outputFile.WriteLine(entry.ToString());
            }

        }
    }

    public void LoadFromFile()
    {
        string filename = "myJournal.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            if (parts.Length < 3)
            {
                Console.WriteLine($"Skipping malformed line: {line}");
                continue;
            }

            string date = parts[0];
            string prompt = parts[1];
            string textEntry = parts[2];

            Entry entryText = new Entry(date, prompt, textEntry);
            _journalEntries.Add(entryText);
        }
    }
}