namespace ASP06EFC.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public required string Name { get; set; }
        public ICollection<Classroom> Classrooms { get; set; }
    }
}
