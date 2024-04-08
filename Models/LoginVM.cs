using System.ComponentModel.DataAnnotations;

namespace HRMS.Models
{
    public class LoginVM
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [MaxLength(10)]
        public string password { get; set; }

    }
}
