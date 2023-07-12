using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class HealthPlan
    {
        [Required(ErrorMessage = "Health Plan Name is required.")]
        [StringLength(25, ErrorMessage = "Health Plan Name must be up to 25 characters")]
        public string? HealthPlan_name { get; set; }
        [Required(ErrorMessage = "Details is required.")]
        [StringLength(25, ErrorMessage = "Details must be up to 900 characters")]
        public string? Details { get; set; }
        [Required(ErrorMessage = "Health Plan Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Health Plan Price must be a positive value")]
        public double? HealthPlan_price { get; set; }
        [Required(ErrorMessage = "Number Of Days is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of Days must be a positive value")]
        public int? No_of_days { get; set; }
    }
}
