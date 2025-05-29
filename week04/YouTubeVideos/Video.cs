//Keep track of title, author, length(seconds), and store list of comments for video
using System.Net;
using System.Transactions;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    //get and set variables
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumOfComments()
    {
        return _comments.Count;
    }

    public void DisplayAllComments()
    {
        Console.WriteLine($"'{_title}' by {_author} is {_length} seconds.");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.GetAuthorName()}: {comment.GetText()}");
        }
    }

}