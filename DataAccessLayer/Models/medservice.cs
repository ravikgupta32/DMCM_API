using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class medservice
    {
        public int Service_Id { get; set; }

        public string Service_Name { get; set; }

        public string Service_Features { get; set; }

        public string Service_Benefits { get;set; }

        public string Service_Parameters { get; set; }
    }
}
