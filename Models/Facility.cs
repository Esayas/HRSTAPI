using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRSTAPI.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FacilityName { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; } = "";
    }
}
