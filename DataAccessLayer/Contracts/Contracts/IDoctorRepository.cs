﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IDoctorRepository
    {
        public string AddDoctor(Doctor doctor);
        
    }
}
