using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.result
{
    public interface IServiceResult
    {
        public List<Report> ViewReport();
    }
}
