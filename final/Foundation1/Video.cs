class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideoInfo()
    {
        return $"------------\nTitle:\n\"{_title}\"\nAuthor:\n\"{_author}\"\nLength:\n{_length} seconds\nAmount of comments:\n{GetCommentAmount()}\nComments:";
    }

    public void DisplayCommentInfo()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment.GetComment()}");
        }
    }

    public void AddComment(string user, string text)
    {
        Comment comment = new Comment(user, text);
        comments.Add(comment);
    }

    public int GetCommentAmount()
    {
        return comments.Count();
    }
}