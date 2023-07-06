using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Contracts
{
    public interface IInsuranceRepository
    {
        public List<Agent> GetAgentDetails();
        public void InsertNomination(Nomination nomination);
    }
}
