using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.insurance
{
    public  class ServiceInsurance:IServiceInsurance
    {
        public readonly IInsuranceRepository _iInsuranceRepository;
        public ServiceInsurance(IInsuranceRepository iInsuranceRepository)
        {
            _iInsuranceRepository = iInsuranceRepository;
        }
        public List<Agent> GetAgentDetails() 
        {
            try {
                return _iInsuranceRepository.GetAgentDetails();
            }
            catch (Exception) { throw; }
        }
        public void InsertNomination(Nomination nomination) 
        {
            try
            {
                _iInsuranceRepository.InsertNomination(nomination);
            }
            catch (Exception) { throw; }

        }
    }
}
