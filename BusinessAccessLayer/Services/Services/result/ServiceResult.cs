using DataAccessLayer.Contracts;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.result
{
    public class ServiceResult:IServiceResult
    {
        public readonly IResultRepository _iResultRepository;
        public ServiceResult(IResultRepository iResultRepository) { 
            _iResultRepository = iResultRepository;
        }
        public List<Report> ViewReport()
        {
            try
            {
                return _iResultRepository.ViewReport().ToList();
            }
            catch (Exception)
            {
                throw;
            } 
        }
    }
}
