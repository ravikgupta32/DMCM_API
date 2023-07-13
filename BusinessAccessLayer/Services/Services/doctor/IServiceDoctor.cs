using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.doctor
{
    public interface IServiceDoctor 
    {
        public Doctor AddDoctor(Doctor doctor);
        

    }
}
