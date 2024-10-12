public class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    public List<Comment> _comments = new List<Comment>();

    int QunttyComments()
    {
        return _comments.Count;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Video: {_title} by {_author} Length : {_lenght} seconds");
        Console.WriteLine($"Video has {QunttyComments()} comments: ");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}