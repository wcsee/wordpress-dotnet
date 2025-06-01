using System.Collections.Generic;

namespace WordPress.NET.Domain.Entities
{
    public class Term
    {
        public int TermId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public long TermGroup { get; set; }
        
        // Navigation properties
        public ICollection<TermTaxonomy> TermTaxonomies { get; set; } = new List<TermTaxonomy>();
        public ICollection<TermMeta> TermMeta { get; set; } = new List<TermMeta>();
    }
}