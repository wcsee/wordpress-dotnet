namespace WordPress.NET.Domain.Entities
{
    public class CommentMeta
    {
        public long MetaId { get; set; }
        public int CommentId { get; set; }
        public string MetaKey { get; set; } = string.Empty;
        public string? MetaValue { get; set; } // Optional field
        
        // Navigation properties
        public Comment Comment { get; set; } = null!;
    }
}