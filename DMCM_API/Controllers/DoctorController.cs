using Dapper;
using DMCM_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DMCM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public readonly string connectionString;
        public DoctorController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        
        
        [HttpGet]
        public IActionResult Get()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var Doctors = connection.Query<Doctor>("SELECT * FROM Doctor_Details").ToList();
                return Ok(Doctors);
            }
        }
        
        [HttpPost]
        public IActionResult Post(Doctor Doctors)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Doctor_Details(Doctor_id,Password,Name,Dob,Email_id,License,Specialization,Mobile) VALUES (@Doctor_id,@Password,@Name,@Dob,@Email_id,@License,@Specialization,@Mobile )";
                connection.Execute(query, Doctors);
            }
            return Ok();
        }


        
        [HttpPut("{id}")]
        public IActionResult Put(string id, Doctor Doctors)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "UPDATE Doctor_Details SET Doctor_id=@Doctor_id,Password=@Password,Name=@Name,Dob=@Dob,Email_id=@Email_id,License=@License,Specialization=@Specialization,Mobile=@Mobile";
                Doctors.Doctor_id = id;
                connection.Execute(query, Doctors);
            }
            return Ok();
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Doctor_Details WHERE Doctor_id=@Doctor_id";
                connection.Execute(query, new { Id = id });
            }
            return Ok();
        }

    }
}

