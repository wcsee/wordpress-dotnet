namespace WordPress.NET.Domain.Entities
{
    public class Option
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; } = string.Empty;
        public string? OptionValue { get; set; } // Optional field
        public string Autoload { get; set; } = "yes";
    }
}