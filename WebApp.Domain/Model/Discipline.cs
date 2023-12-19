using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Model
{
    public class Discipline
    {
        [Key]
        public string Name { get; set; } = null!;
        public string Hours { get; set; } = null!;

        // Relationships
        public Teacher Teacher { get; set; } = null!;
    }
}