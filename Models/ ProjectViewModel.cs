using System.Text.Json.Serialization;

namespace petrine.no.Models
{
    public class ProjectViewModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Url { get; set; }
    }
}