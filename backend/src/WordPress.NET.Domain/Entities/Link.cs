using System;

namespace WordPress.NET.Domain.Entities
{
    public class Link
    {
        public int LinkId { get; set; }
        public string LinkUrl { get; set; } = string.Empty;
        public string LinkName { get; set; } = string.Empty;
        public string? LinkImage { get; set; } // Optional field
        public string? LinkTarget { get; set; } // Optional field
        public string? LinkDescription { get; set; } // Optional field
        public string LinkVisible { get; set; } = "Y";
        public int LinkOwner { get; set; }
        public int LinkRating { get; set; }
        public DateTime LinkUpdated { get; set; }
        public string? LinkRel { get; set; } // Optional field
        public string? LinkNotes { get; set; } // Optional field
        public string? LinkRss { get; set; } // Optional field
    }
}