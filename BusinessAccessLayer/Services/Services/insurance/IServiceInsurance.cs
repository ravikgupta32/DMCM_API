using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.insurance
{
    public interface IServiceInsurance
    {
        public List<Agent> GetAgentDetails();
        public void InsertNomination(Nomination nomination);
    }
}
