using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string ClassName { get; set; }
        public string RoomName { get; set; }

        //[ForeignKey("ClassId")]
        //public string ClassId { get; set; }
        public virtual List<Student>? Students { get; set; }
    }
}
