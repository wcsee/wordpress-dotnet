namespace WordPress.NET.Domain.Enums
{
    public enum CommentStatus
    {
        Approved = 1,
        Pending = 0,
        Spam = -1,
        Trash = -2
    }
}