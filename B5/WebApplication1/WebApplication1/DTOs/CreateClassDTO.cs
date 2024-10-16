using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs
{
    public class CreateClassDTO
    {
        [DisplayName("Class name")]
        public string ClassName { get; set; }
        [DisplayName("Class room")]
        public string RoomName { get; set; }
    }
}
