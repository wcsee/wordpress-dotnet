namespace WordPress.NET.Domain.Entities
{
    public class UserMeta
    {
        public long MetaId { get; set; }
        public int UserId { get; set; }
        public string MetaKey { get; set; } = string.Empty;
        public string? MetaValue { get; set; } // Optional field
        
        // Navigation properties
        public User User { get; set; } = null!;
    }
}