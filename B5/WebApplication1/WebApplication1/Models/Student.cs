using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(18, 30, ErrorMessage = "Only accept form 18 to 30 year old")]
        public int Age { get; set; }

        [MaxLength (200, ErrorMessage = "Can't have more than 200 character")]
        public string Address { get; set; }

        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
