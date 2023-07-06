using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.healthplan
{
    public  class ServiceHealthPlan:IServiceHealthPlan
    {
        public readonly IHealthPlanRepository _iHealthPlanRepository;
        public ServiceHealthPlan(IHealthPlanRepository iHealthPlanRepository)
        {
            _iHealthPlanRepository = iHealthPlanRepository;
        }

        public List<string> GetPlanNames()
        {
            try 
            {
                return _iHealthPlanRepository.GetPlanNames();
            } 
            catch(Exception) {
                throw;
            }
        }
        public List<HealthPlan> GetHealthPlanDetails(string PlanName) {
            try
            {
                return _iHealthPlanRepository.GetHealthPlanDetails(PlanName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
