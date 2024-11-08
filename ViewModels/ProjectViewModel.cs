using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace petrine.no.ViewModels
{
    public class ProjectViewModel
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }  // Required field, non-nullable

        [JsonPropertyName("description")]
        public string? Description { get; set; } = string.Empty;  // Nullable, with default value

        [JsonPropertyName("html_url")]
        public string? Url { get; set; } = string.Empty;  // Nullable, with default value

        [JsonPropertyName("created_at")]
        public required DateTime CreatedAt { get; set; }  // Required, non-nullable

        public string ProjectCardImageUrl { get; set; } = "/assets/img/RettVest(hero).png";  // Default card image URL
        public string ProjectCardImageAlt { get; set; } = "/assets/img/card-cm.png";  // Default card image alt
    }
}