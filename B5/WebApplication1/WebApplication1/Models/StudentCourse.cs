using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }

        public string CourseId { get; set; }
    }
}
