using System.Collections.Generic;

namespace WordPress.NET.Domain.Entities
{
    public class TermTaxonomy
    {
        public int TermTaxonomyId { get; set; }
        public int TermId { get; set; }
        public string Taxonomy { get; set; } = string.Empty;
        public string? Description { get; set; } // Optional field
        public int Parent { get; set; }
        public long Count { get; set; }
        
        // Navigation properties
        public Term Term { get; set; } = null!;
        public TermTaxonomy? ParentTaxonomy { get; set; } // Can be null for top-level taxonomies
        public ICollection<TermTaxonomy> Children { get; set; } = new List<TermTaxonomy>();
        public ICollection<TermRelationship> TermRelationships { get; set; } = new List<TermRelationship>();
    }
}