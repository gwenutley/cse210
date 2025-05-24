public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Random random = new Random();

    public Scripture(string text)
    {
        _reference = new Reference();
        _words = new List<Word>();

        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetReference()
    {
        return _reference.ToString();
    }

    public void HideRandom(int numToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (var word in _words) { 
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        numToHide = Math.Min(numToHide, visibleWords.Count);
        for (int i = 0; i < numToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (var word in _words)
        {
            result += word.DisplayWord() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true;
    }

}