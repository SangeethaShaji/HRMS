using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.Entities
{
    public class Employess
    {
        [Key]
        public int Id { get; set; }
        required
        public string Name { get; set; }
    
        [DataType(DataType.EmailAddress)]
         
        public string Email { get; set; }
       
        public string Phone { get; set; }
        public string Gender { get; set; }
        
        public required string Address { get; set; }
        public string Designation { get; set; }
        public DateOnly Date_Of_Join { get; set; }
        public string password { get; set; }



    }
}
