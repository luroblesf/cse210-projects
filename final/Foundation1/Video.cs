using System;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;


    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(List<Comment> comment)
    {
       _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        int commentCount = GetNumberComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}