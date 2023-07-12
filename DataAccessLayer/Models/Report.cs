using System.ComponentModel.DataAnnotations;
namespace DataAccessLayer.Models
{
    public class Report
    {
        [Required(ErrorMessage = "Report ID is required.")]
        [StringLength(25, ErrorMessage = "Repport ID must be up to 25 characters")]
        public string Report_Id { get; set; }
        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(25, ErrorMessage = "Customer Name must be up to 25 characters")]
        public string Customer_Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(25, ErrorMessage = "Email must be up to 25 characters")]
        public string Email_Id { get; set; }
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile Number must be in int and 10 digits ")]
        public long Mobile_Number { get; set; }
        [Required(ErrorMessage = "Doctor Name is required.")]
        [StringLength(25, ErrorMessage = "Doctor Name must be up to 25 characters")]
        public string Doctor_name { get; set; }
        [Required(ErrorMessage = "Diagnosis is required.")]
        [StringLength(25, ErrorMessage = "Diagnosis must be up to 25 characters")]
        public string Diagnosis { get; set; }
        [Required(ErrorMessage = "Result is required.")]
        [StringLength(25, ErrorMessage = "Result must be up to 25 characters")]
        public string Result { get; set; }

        public string Nomination_details_id { get; set; }





    }
}
