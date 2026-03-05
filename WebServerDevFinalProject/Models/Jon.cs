using System.ComponentModel.DataAnnotations;

namespace WebServerDevFinalProject.Models
{
    public class Jon
    {
        [Key]
        public int JonId { get; set; }
        public string? HobbyName { get; set; }
        public string? Category { get; set; }   // Sports, Gaming, Music, Art, etc.
        public string? Description { get; set; } // Ex. Collect Rare Diecast Cars
        public string? Environment { get; set; } // Indoor / Outdoor / Both
        public string? SkillLevel { get; set; } // Beginner, Intermediate, Advanced
        public int? HobbyAge { get; set; } // 1,2,3, etc years


    }
}
