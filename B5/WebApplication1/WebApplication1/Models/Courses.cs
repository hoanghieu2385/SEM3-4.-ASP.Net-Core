using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
