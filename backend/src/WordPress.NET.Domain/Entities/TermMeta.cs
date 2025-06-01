namespace WordPress.NET.Domain.Entities
{
    public class TermMeta
    {
        public long MetaId { get; set; }
        public int TermId { get; set; }
        public string MetaKey { get; set; } = string.Empty;
        public string? MetaValue { get; set; } // Optional field
        
        // Navigation properties
        public Term Term { get; set; } = null!;
    }
}