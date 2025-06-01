namespace WordPress.NET.Domain.Entities
{
    public class PostMeta
    {
        public long MetaId { get; set; }
        public int PostId { get; set; }
        public string MetaKey { get; set; } = string.Empty;
        public string? MetaValue { get; set; } // Optional field
        
        // Navigation properties
        public Post Post { get; set; } = null!;
    }
}