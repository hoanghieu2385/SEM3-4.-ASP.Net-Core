using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class CreateClassDTO
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }
        [Display(Name = "Room name")]
        public string RoomName { get; set; }
    }
}
