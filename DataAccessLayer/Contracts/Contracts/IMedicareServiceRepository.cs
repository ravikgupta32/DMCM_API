using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Contracts
{
    public interface IMedicareServiceRepository
    {
        public List<string> GetPlanNames();
        public List<medservice> GetPlanDetails(string planName);
    }
}
