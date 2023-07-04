using Dapper;
using DataAccessLayer.DataAccess;
using DMCM_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DMCM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registration : ControllerBase
    {
        CustomerRepository customerrp = new CustomerRepository();
        DoctorRepository doctorrp = new DoctorRepository();
       
        [HttpGet("/Customer")]
        public IActionResult GetCustomerDetails()
        {
            List<Customer> customerdetails = customerrp.GetCustomerDetails();
            return Ok(customerdetails);
        }
        [HttpGet("/Doctor")]
        public IActionResult GetDoctorDetails()
        {
            List<Doctor> doc_details = doctorrp.GetDoctorDetails();
            return Ok(doc_details);
        }
        [HttpPost("/SubmitCustomerDetails")]
        public IActionResult SubmitCustomerDetails(Customer customer) {
            customerrp.AddCustomer(customer);
            return Ok("Successfully Added Customer");
        }
        [HttpPost("/SubmitDoctorDetails")]
        public IActionResult SubmitDocotrDetails(Doctor doctor)
        {
            doctorrp.AddDoctor(doctor);
            return Ok("Successfully Added Doctor");
        }

    }
}

