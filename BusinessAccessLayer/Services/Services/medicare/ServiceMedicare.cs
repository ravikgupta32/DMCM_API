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
            try { 
                return _iMedicareServiceRepository.GetPlanNames();
            }
            catch (Exception) {
                throw;
            }
        }
        public List<medservice> GetPlanDetails(string planName)
        {
            try 
            { 
                return _iMedicareServiceRepository.GetPlanDetails(planName);
            } catch (Exception)
            {
                throw;
            }
        }
    }
}
