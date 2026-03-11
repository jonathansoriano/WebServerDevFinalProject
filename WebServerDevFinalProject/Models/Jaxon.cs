using System.ComponentModel.DataAnnotations;

namespace WebServerDevFinalProject.Models
{
    public class Jaxon
    {
        [Key]

        public int JaxonId { get; set; }
        public string? HobbyName { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public string? Environment { get; set; }

        public string? SkillLevel { get; set; }

        public int? HobbyAge { get; set; }
    }
}