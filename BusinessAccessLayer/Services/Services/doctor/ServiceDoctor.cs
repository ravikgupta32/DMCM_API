﻿using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.doctor
{

    public class ServiceDoctor : IServiceDoctor
    {
        public readonly IDoctorRepository _idoctorrepository;
        public ServiceDoctor(IDoctorRepository doctorrepository) { _idoctorrepository = doctorrepository; }
        public Doctor AddDoctor(Doctor doctor)
        {
            try
            { 
                return _idoctorrepository.AddDoctor(doctor);
            }

            catch (Exception)
            { throw; }

        }

        public List<Doctor> GetDoctorDetails()
        {
            try
            {
                return _idoctorrepository.GetDoctorDetails().ToList();
            }
            catch(Exception)
            { throw; }
            
        }
    }
}