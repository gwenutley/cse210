using System.Diagnostics;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string GetVerse()
    {
        return _text;
    }

    public void ReturnVerse(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string DisplayWord()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); 
        }
        else
        {
            return _text; 
        }
    }
}