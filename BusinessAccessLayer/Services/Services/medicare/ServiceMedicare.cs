using DataAccessLayer.Contracts.Contracts;
using DataAccessLayer.Models;

namespace BusinessAccessLayer.Services.Services.medicare
{
    public class ServiceMedicare:IServiceMedicare
    {
        public readonly IMedicareServiceRepository _iMedicareServiceRepository;

        public ServiceMedicare(IMedicareServiceRepository iMedicareServiceRepository)
        {
            _iMedicareServiceRepository = iMedicareServiceRepository;
        }
        public List<string> GetPlanNames()
        {
            
                return _iMedicareServiceRepository.GetPlanNames();
            
           
        }
        public List<medservice> GetPlanDetails(string planName)
        {
                return _iMedicareServiceRepository.GetPlanDetails(planName);
            
        }
    }
}
