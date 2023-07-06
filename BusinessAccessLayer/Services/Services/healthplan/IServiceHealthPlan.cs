using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.healthplan
{
    public interface IServiceHealthPlan
    {
        public List<string> GetPlanNames();
        public List<HealthPlan> GetHealthPlanDetails(string PlanName);
    }
}
