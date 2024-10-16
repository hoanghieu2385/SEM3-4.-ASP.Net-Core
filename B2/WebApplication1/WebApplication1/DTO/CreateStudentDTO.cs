using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class CreateStudentDTO
    {
        [Display(Name = "Student name")]
        public int Id { get; set; }
        public string StudentName { get; set; }

    }
}
