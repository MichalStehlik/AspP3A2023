using System.ComponentModel.DataAnnotations.Schema;

namespace ASP06EFC.Models
{
    public class ClassroomSubject
    {
        //[Key]
        [ForeignKey("Classroom")]
        public int ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        //[Key]
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
