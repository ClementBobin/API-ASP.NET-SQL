namespace ChuckNorrisApi.Models
{
    public class ChuckNorrisQuote
    {
        public int Id { get; set; }
        public string Quote { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Add this for source URL
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
