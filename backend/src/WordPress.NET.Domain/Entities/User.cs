using System;
using System.Collections.Generic;

namespace WordPress.NET.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; } = string.Empty;
        public string UserPass { get; set; } = string.Empty;
        public string UserNicename { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string? UserUrl { get; set; } // Optional field
        public DateTime UserRegistered { get; set; }
        public string? UserActivationKey { get; set; } // Optional field
        public int UserStatus { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        
        // Navigation properties
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<UserMeta> UserMeta { get; set; } = new List<UserMeta>();
    }
}