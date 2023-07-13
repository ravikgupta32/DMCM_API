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
                return _iInsuranceRepository.GetAgentDetails();
        }
        public void InsertNomination(Nomination nomination) 
        {
                _iInsuranceRepository.InsertNomination(nomination);
        }
    }
}
