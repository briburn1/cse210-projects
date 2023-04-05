public class Video 
{
    // protected or private?
    string _title;
    string _author;
    float _videoLength; // in seconds

    // store list of comments
    List<Comment> _comments;

    // method to return number of comments
    public int GetComment()
    {
        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public Video(string title, string author, float videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }
}