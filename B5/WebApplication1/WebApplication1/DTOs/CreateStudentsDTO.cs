using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.DTOs
{
    public class CreateStudentsDTO
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Range(18, 30, ErrorMessage = "Only accept form 18 to 30 year old")]
        public int Age { get; set; }

        [MaxLength(200, ErrorMessage = "Can't have more than 200 character")]
        public string Address { get; set; }
        public int ClassId { get; set; }
    }
}
