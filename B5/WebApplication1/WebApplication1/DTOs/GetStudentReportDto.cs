using System.ComponentModel;

namespace WebApplication1.DTOs
{
    public class GetStudentReportDto
    {
        [DisplayName("Student name")]
        public string StudentName { get; set; }
        [DisplayName("Student Age")]
        public int Age { get; set; }
        [DisplayName("Student address")]
        public string Address { get; set; }
        [DisplayName("Course name")]
        public string CourseName { get; set; }
        [DisplayName("Class Name")]
        public int ClassName { get; set; }
    }
}
