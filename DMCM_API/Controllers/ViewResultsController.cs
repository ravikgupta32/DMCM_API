using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

using Microsoft.Data.SqlClient;
using DataAccessLayer.DataAccess;
using DMCM_API.Models;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewResultsController : ControllerBase
    {
        ResultRepository reportrepository = new ResultRepository();
        [HttpGet("/ViewReports")]
        public IActionResult GetResults()
        {
            List<Report> reports = reportrepository.ViewReport();
            return Ok(reports);

        }
        /*private readonly string ConnectionString;
        public ViewResultsController(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");

        }
        [HttpGet]
        public IActionResult GetReports()
        {
            List<Report> reports = new List<Report>();



            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Reports";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Report report = new Report
                            {
                                Report_Id = reader["ReportId"].ToString(),
                                Customer_Name = reader["Customer_Name"].ToString(),
                                Dob = Convert.ToDateTime(reader["Dob"]),
                                Email_Id = reader["Email_Id"].ToString(),
                                Mobile_Number = Convert.ToInt32(reader["Mobile_Number"]),
                                Doctor_name = reader["Doctor_Name"].ToString(),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                Result = reader["Result"].ToString(),
                                Nomination_details_id = Convert.ToInt32(reader["Nomination_details_id"])
                            };



                            reports.Add(report);
                        }
                    }
                }
            }



            return Ok(reports);
        }



        [HttpGet("{id}")]
        public IActionResult GetReport(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Reports WHERE ReportId = @Id";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Report report = new Report
                            {
                                Report_Id = reader["Report_Id"].ToString(),
                                Customer_Name = reader["Customer_Name"].ToString(),
                                Dob = Convert.ToDateTime(reader["Dob"]),
                                Email_Id = reader["EmailId"].ToString(),
                                Mobile_Number = Convert.ToInt32(reader["MobileNumber"]),
                                Doctor_name = reader["DoctorName"].ToString(),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                Result = reader["Result"].ToString(),
                                Nomination_details_id = Convert.ToInt32(reader["Nomination_details_id"])
                            };



                            return Ok(report);
                        }
                    }
                }
            }



            return NotFound();
        }
    }
*/

    }
}
