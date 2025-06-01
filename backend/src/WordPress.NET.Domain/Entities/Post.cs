using System;
using System.Collections.Generic;
using WordPress.NET.Domain.Enums;
using WordPress.NET.Domain.ValueObjects;

namespace WordPress.NET.Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostDateGmt { get; set; }
        public PostContent Content { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string? Excerpt { get; set; } // Optional field
        public PostStatus Status { get; set; }
        public string CommentStatus { get; set; } = "open";
        public string PingStatus { get; set; } = "open";
        public string? PostPassword { get; set; } // Optional field
        public string PostName { get; set; } = string.Empty; // slug
        public string? ToPing { get; set; } // Optional field
        public string? Pinged { get; set; } // Optional field
        public DateTime PostModified { get; set; }
        public DateTime PostModifiedGmt { get; set; }
        public string? PostContentFiltered { get; set; } // Optional field
        public int PostParent { get; set; }
        public string Guid { get; set; } = string.Empty;
        public int MenuOrder { get; set; }
        public PostType PostType { get; set; }
        public string? PostMimeType { get; set; } // Optional field
        public long CommentCount { get; set; }
        
        // Navigation properties
        public User Author { get; set; } = null!;
        public Post? Parent { get; set; } // Can be null for top-level posts
        public ICollection<Post> Children { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<PostMeta> PostMeta { get; set; } = new List<PostMeta>();
        public ICollection<TermRelationship> TermRelationships { get; set; } = new List<TermRelationship>();
    }
}