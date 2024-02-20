using System.ComponentModel.DataAnnotations;

namespace ASP06EFC.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        [Required]
        public required string Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Subject> Subjects { get; set; }
    }
}
