public class Comment
{
    public string _userName;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"{_userName} wrote: {_text}");
    }
}