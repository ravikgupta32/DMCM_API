using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Nomination
    {
        public string? Name { get; set; }
        public DateTime DOB { get; set; }
        public string? Email_id { get; set; }
        public long? Mobile_number { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }

        public string? City_Name { get; set; }
        public int Pin_code { get; set; }
        public int Healthplan_id { get; set; }

    }
}
