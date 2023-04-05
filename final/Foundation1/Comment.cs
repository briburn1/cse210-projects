public class Comment 
{
    // protected or private?
    string _name;
    string _commentText;

    // tracking name of person who made comment
    // text of the comment
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
}