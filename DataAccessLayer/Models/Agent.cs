using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Agent
    {
        [Required(ErrorMessage = "Agent ID is required.")]
        [StringLength(25, ErrorMessage = "Agent ID must be up to 25 characters")]
        public string? Agent_id { get; set; }
        [Required(ErrorMessage = "Agent Name is required.")]
        [StringLength(25, ErrorMessage = "Agent Name must be up to 25 characters")]
       
        public string? Agent_name { get; set; }
        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(25, ErrorMessage = "Street Address must be up to 25 characters")]
        public string? Street_address { get; set; }
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]
        public string? Mobile_number { get; set; }
        [Required(ErrorMessage = "City is required.")]
        [StringLength(25, ErrorMessage = "City must be up to 25 characters")]
        public string? City { get; set; }
        [Required(ErrorMessage = "State is required.")]
        [StringLength(25, ErrorMessage = "State must be up to 25 characters")]
        public string? State { get; set; }
        [Required(ErrorMessage = "Pincode is required.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Pin code must be in int and 6 digits ")]
        public int Pincode { get; set; }

    }
}
