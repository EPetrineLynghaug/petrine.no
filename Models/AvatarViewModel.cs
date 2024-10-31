using System.Text.Json.Serialization;

namespace petrine.no.Models
{
    public class ProjectWithAvatarViewModel
    {
        public ProjectViewModel? Project { get; set; }
        public ProjectWithAvatarViewModel? Avatar { get; set; } // Avatar kan være null
    }
}