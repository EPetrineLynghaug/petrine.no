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
      
    }
    
}