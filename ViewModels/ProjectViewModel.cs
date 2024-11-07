// ViewModels/ProjectViewModel.cs
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

        [JsonPropertyName("updated_at")]
        public DateTime LastUpdated { get; set; } = DateTime.Now;  // Default to current date/time

        // Optional summary for additional information not from GitHub API
        public string Summary { get; set; } = string.Empty;

        // Collection of languages used in the project
        public Dictionary<string, int> Languages { get; set; } = new();

        // Use this for the card image
        public string ProjectCardImageUrl { get; set; } = "/assets/img/RettVest(hero).png";  // Default card image URL
    }
}