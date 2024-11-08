namespace MyApp.Models
{
    public class Project
    {
        public int Id { get; set; }                     // Unique identifier for the project
        public string Name { get; set; } = string.Empty; // Name of the project
        public string Description { get; set; } = string.Empty; // Description of the project
        public DateTime StartDate { get; set; }          // Start date of the project
        public DateTime? EndDate { get; set; }           // Nullable end date, allowing ongoing projects
        public string Status { get; set; } = "Active";   // Status, defaulting to "Active"
    }
}