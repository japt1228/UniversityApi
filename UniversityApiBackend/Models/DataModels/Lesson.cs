using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public int ChapterId { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}
