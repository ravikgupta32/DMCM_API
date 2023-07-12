using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "User ID is required.")]
        [StringLength(25, ErrorMessage = "User ID must be up to 25 characters")]

        public string? Userid { get; set; }

        [Required]
        [PasswordPropertyText]
        [StringLength(25, ErrorMessage = "Password must be up to 25 characters")]

        public string? Password { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name must be up to 25 characters")]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]

        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        [StringLength(25, ErrorMessage = "Email must be up to 25 characters")]

        public string? Email { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]

        public string? Address { get; set; }
        
        
     
       

    }
}
