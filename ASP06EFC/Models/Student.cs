using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP06EFC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        // tabulkaId, Id je klíč dle konvence
        //[Key] // anotace, která říká, že tohle je klíč
        //public int Klíč { get; set; }
        [Required]
        [Display(Name = "Jméno")]
        public string FirstName { get; set; } = string.Empty;
        public required string LastName { get; set; }
        //[ForeignKey("Classroom")]
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
