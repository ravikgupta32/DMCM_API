using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Agent
    {
        public string? Agent_id { get; set; }
        public string? Agent_name { get; set; }
        public string? Street_address { get; set; }
        public long Mobile_number { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Pincode { get; set; }

    }
}
