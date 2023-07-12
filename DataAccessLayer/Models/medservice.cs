using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class medservice
    {
        [Required(ErrorMessage = "Service ID is required.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Service ID must be in int and 4 digits ")]
        public int Service_Id { get; set; }
        [Required(ErrorMessage = "Service Name is required.")]
        [StringLength(25, ErrorMessage = "Service Name must be up to 25 characters")]
        public string Service_Name { get; set; }

        [Required(ErrorMessage = "Service Features is required.")]
        [StringLength(25, ErrorMessage = "Service Features must be up to 25 characters")]
        public string Service_Features { get; set; }
        [Required(ErrorMessage = "Service Benefits is required.")]
        [StringLength(25, ErrorMessage = "Service Benefits must be up to 25 characters")]
        public string Service_Benefits { get;set; }
        [Required(ErrorMessage = " Service Parameters is required.")]
        [StringLength(25, ErrorMessage = "Service Parameters must be up to 25 characters")]
        public string Service_Parameters { get; set; }
    }
}
