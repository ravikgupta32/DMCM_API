using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer.Models
{
    public class Doctor
    {
        [Required(ErrorMessage = "Doctor ID is required.")]
        [StringLength(25, ErrorMessage = "Doctor ID must be up to 25 characters")]
        public string? Doctor_id { get; set; }

        [Required(ErrorMessage = "Password is required.")]
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
        public string? Email_id { get; set; }

        [Required(ErrorMessage = "License is required.")]
        [StringLength(25, ErrorMessage = "License must be up to 25 characters")]
        public string? License { get; set; }
        [Required(ErrorMessage = "Specialization is required.")]
        [StringLength(25, ErrorMessage = "Specialization must be up to 25 characters")]

        public string? Specialization { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]

        public string? Mobile { get; set; }
    }
}
