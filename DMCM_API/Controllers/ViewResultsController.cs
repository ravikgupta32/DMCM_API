using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using DMCM_API.Models;
using Microsoft.Data.SqlClient;

namespace DMCM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewResultsController : ControllerBase
    {
        private readonly string ConnectionString;
        public ViewResultsController(IConfiguration configuration) {
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



        [HttpPost]
        public IActionResult CreateReport([FromBody] Report report)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Reports (Report_Id,Customer_Name, Dob, Email_Id, Mobile_Number, Doctor_Name, Diagnosis, Result, Nomination_details_id) " +
                "VALUES (@Report_Id,@Customer_Name, @Dob, @Email_Id, @Mobile_Number, @Doctor_Name, @Diagnosis, @Result, @Nomination_details_id)";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Report_Id", report.Report_Id);
                    command.Parameters.AddWithValue("@CustomerName", report.Customer_Name);
                    command.Parameters.AddWithValue("@Dob", report.Dob);
                    command.Parameters.AddWithValue("@EmailId", report.Email_Id);
                    command.Parameters.AddWithValue("@MobileNumber", report.Mobile_Number);
                    command.Parameters.AddWithValue("@DoctorName", report.Doctor_name);
                    command.Parameters.AddWithValue("@Diagnosis", report.Diagnosis);
                    command.Parameters.AddWithValue("@Result", report.Result);
                    command.Parameters.AddWithValue("@Nomination_details_id", report.Nomination_details_id);



                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }



            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateReport(int id, [FromBody] Report report)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE Reports SET CustomerName = @CustomerName, Dob = @Dob, EmailId = @EmailId, " +
                "MobileNumber = @MobileNumber, DoctorName = @DoctorName, Diagnosis = @Diagnosis, " +
                "Result = @Result, Nomination_details_id = @Nomination_details_id " +
                "WHERE ReportId = @Id";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", report.Customer_Name);
                    command.Parameters.AddWithValue("@Dob", report.Dob);
                    command.Parameters.AddWithValue("@EmailId", report.Email_Id);
                    command.Parameters.AddWithValue("@MobileNumber", report.Mobile_Number);
                    command.Parameters.AddWithValue("@DoctorName", report.Doctor_name);
                    command.Parameters.AddWithValue("@Diagnosis", report.Diagnosis);
                    command.Parameters.AddWithValue("@Result", report.Result);
                    command.Parameters.AddWithValue("@Nomination_details_id", report.Nomination_details_id);
                    command.Parameters.AddWithValue("@Id", id);



                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();



                    if (rowsAffected > 0)
                    {
                        return Ok();
                    }
                }
            }



            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeleteReport(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Reports WHERE ReportId = @Id";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);



                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();



                    if (rowsAffected > 0)
                    {
                        return Ok();
                    }
                }
            }



            return NotFound();
        }
    }
}
