// ViewModels/ProjectViewModel.cs
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace petrine.no.ViewModels
{
    public class ProjectViewModel
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }  // Required, non-nullable

        [JsonPropertyName("description")]
        public string? Description { get; set; }  // Nullable

        [JsonPropertyName("html_url")]
        public string? Url { get; set; }  // Nullable for missing URL data

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime LastUpdated { get; set; }

        // Optional summary not tied to GitHub API
        public string Summary { get; set; } = string.Empty;

        // Collection of languages used in the project
        public Dictionary<string, int> Languages { get; set; } = new();

        // Hero section properties for display customization
        public string HeroTitle { get; set; } = "Welcome to Petrine.no!";
        public string HeroSubtitle { get; set; } = "Explore our projects and blog.";
        public string HeroImageUrl { get; set; } = "https://via.placeholder.com/1200x400";
    }
}