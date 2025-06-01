namespace WordPress.NET.Domain.Entities
{
    public class TermRelationship
    {
        public int ObjectId { get; set; }
        public int TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
        
        // Navigation properties
        public Post? Post { get; set; }
        public TermTaxonomy? TermTaxonomy { get; set; }
    }
}