using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Nomination
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name must be up to 25 characters")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        [StringLength(25, ErrorMessage = "Email must be up to 25 characters")]
        public string? Email_id { get; set; }
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]
        public string? Mobile_number { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        [StringLength(25, ErrorMessage = "Country must be up to 25 characters")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "State is required.")]
        [StringLength(25, ErrorMessage = "State must be up to 25 characters")]
        public string? State { get; set; }
        [Required(ErrorMessage = "City Name is required.")]
        [StringLength(25, ErrorMessage = "City Name must be up to 25 characters")]
        public string? City_Name { get; set; }
        [Required(ErrorMessage = "Pincode is required.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Pin code must be in int and 6 digits ")]
        public int Pin_code { get; set; }
        [Required(ErrorMessage = "Health Plan ID is required.")]
        public int Healthplan_id { get; set; }

    }
}
