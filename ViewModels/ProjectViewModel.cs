using System;
using System.Text.Json.Serialization;

namespace petrine.no.ViewModels
{
    public class ProjectViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string? Description { get; set; } = string.Empty;

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        // Legg til Url-egenskapen for å bruke med href-lenken
        public string Url { get; set; } = string.Empty;

        public string ProjectCardImageUrl
        {
            get
            {
                return Name switch
                {
                    "RettVest" => "/assets/img/RettVest(hero).png",
                    "Community-Science-Museum" => "/assets/img/museum.png",
                    _ => "/assets/img/default.png"
                };
            }
        }

        public string ProjectCardImageAlt => $"{Name} Project Image";
    }

    public class BlogPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        // Legg til Content for å lagre blogginnleggets fulle innhold
        public string Content { get; set; } = string.Empty;


    }
}