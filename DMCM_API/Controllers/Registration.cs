using BusinessAccessLayer.Services.customer;
using BusinessAccessLayer.Services.doctor;
using Dapper;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    

   

    [Route("api/[controller]")]
    [ApiController]
    public class Registration : ControllerBase
    {
        public IServiceCustomer _iServiceCustomer;
        public IServiceDoctor _iDoctor;
        public Registration(IServiceCustomer iServiceCustomer, IServiceDoctor iDoctor)
        {
            _iServiceCustomer = iServiceCustomer;
            _iDoctor = iDoctor;
        }

        [Authorize(Roles = "Customer")]
        [HttpPost("/SubmitCustomerDetails")]
        public IActionResult SubmitCustomerDetails(Customer customer)
        {
            try
            {
                return Ok(_iServiceCustomer.AddCustomer(customer));
            }
            catch (Exception ex)

            {
                if(ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                    return BadRequest("Data already exists kindly try with different customer id.");
                return BadRequest(ex.Message);
            }
        }
        [Authorize(Roles = "Doctor")]
        [HttpPost("/SubmitDoctorDetails")]
        public IActionResult SubmitDoctorDetails(Doctor doctor)
        {
            try
            {
                return Ok( _iDoctor.AddDoctor(doctor));
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                    return BadRequest("Data already exists kindly try with different doctor id.");
                return BadRequest(ex.Message);
            }
        }
    }
}

