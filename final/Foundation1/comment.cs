public class Comment
{
    public string CommenterName { get; private set; }
    public string CommentText { get; private set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}


