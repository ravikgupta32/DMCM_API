using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class HealthPlan
    {
        public string? HealthPlan_name { get; set; }
        public string? Details { get; set; }
        public double? HealthPlan_price { get; set; }

        public int? No_of_days { get; set; }
    }
}
