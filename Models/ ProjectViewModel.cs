using System.Text.Json.Serialization;

namespace petrine.no.Models
{
    public class ProjectViewModel
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("html_url")]
        public required string Url { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime LastUpdated { get; set; }

        // New properties to hold language details and a short summary
        public string Summary { get; set; } = string.Empty;

        // Collection of languages associated with the project, populated separately if needed
        public Dictionary<string, int> Languages { get; set; } = new();
    }
}