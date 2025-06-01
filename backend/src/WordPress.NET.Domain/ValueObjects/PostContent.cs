using System;
using System.Collections.Generic;
using System.Linq;

namespace WordPress.NET.Domain.ValueObjects
{
    public class PostContent : IEquatable<PostContent>
    {
        public string Raw { get; private set; } = string.Empty;
        public string Rendered { get; private set; } = string.Empty;
        public bool Protected { get; private set; }
        
        public PostContent(string? raw, string? rendered = null, bool isProtected = false)
        {
            Raw = raw ?? string.Empty;
            Rendered = rendered ?? ProcessContent(raw);
            Protected = isProtected;
        }
        
        private static string ProcessContent(string? raw)
        {
            if (string.IsNullOrEmpty(raw))
                return string.Empty;
                
            // Basic content processing (wpautop equivalent)
            var content = raw.Replace("\r\n", "\n").Replace("\r", "\n");
            
            // Convert double line breaks to paragraphs
            var paragraphs = content.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .Select(p => $"<p>{p.Replace("\n", "<br />")}</p>");
                
            return string.Join("\n\n", paragraphs);
        }
        
        public bool Equals(PostContent? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Raw == other.Raw && Protected == other.Protected;
        }
        
        public override bool Equals(object? obj)
        {
            return Equals(obj as PostContent);
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Raw, Protected);
        }
        
        public static bool operator ==(PostContent? left, PostContent? right)
        {
            return Equals(left, right);
        }
        
        public static bool operator !=(PostContent? left, PostContent? right)
        {
            return !Equals(left, right);
        }
        
        public override string ToString()
        {
            return Protected ? "[Protected Content]" : Rendered;
        }
    }
}