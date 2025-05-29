public class Comment
{
    private string _authorName;
    private string _text;
    public void SetAuthorName(string authorName)
    {
        _authorName = authorName;
    }

    public string GetAuthorName()
    {
        return _authorName;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }

}