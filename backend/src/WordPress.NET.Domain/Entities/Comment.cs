using System;
using System.Collections.Generic;
using WordPress.NET.Domain.Enums;

namespace WordPress.NET.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int CommentPostId { get; set; }
        public string CommentAuthor { get; set; } = string.Empty;
        public string CommentAuthorEmail { get; set; } = string.Empty;
        public string? CommentAuthorUrl { get; set; } // Optional field
        public string? CommentAuthorIp { get; set; } // Optional field
        public DateTime CommentDate { get; set; }
        public DateTime CommentDateGmt { get; set; }
        public string CommentContent { get; set; } = string.Empty;
        public int CommentKarma { get; set; }
        public CommentStatus CommentApproved { get; set; }
        public string? CommentAgent { get; set; } // Optional field
        public string CommentType { get; set; } = string.Empty;
        public int CommentParent { get; set; }
        public int? UserId { get; set; } // Can be null for anonymous comments
        
        // Navigation properties
        public Post Post { get; set; } = null!;
        public User? User { get; set; } // Can be null for anonymous comments
        public Comment? Parent { get; set; } // Can be null for top-level comments
        public ICollection<Comment> Replies { get; set; } = new List<Comment>();
        public ICollection<CommentMeta> CommentMeta { get; set; } = new List<CommentMeta>();
    }
}