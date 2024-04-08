using System.ComponentModel.DataAnnotations;

namespace HRMS.Models
{
    public class AddEmployeView
    {
        [Key]
        public int Id { get; set; }  
        [StringLength(30)]
        [MaxLength(30)]
        [Required(ErrorMessage ="username is required")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required]
        //[MaxLength(10)]
        //[Phone]
        //[RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid 10-digit phone number.")]
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [StringLength(30)]
        [MaxLength(30)]
        [Required]
        public string Address { get; set; }
        public string Designation { get; set; }
        [Required(ErrorMessage ="Date of joining required")]
        public DateOnly Date_Of_Join { get; set; }
        //[MaxLength(10)]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.*\d).{8,}$",
        //ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and be at least 8 characters long")]
        public string password { get; set; }


    }
}
