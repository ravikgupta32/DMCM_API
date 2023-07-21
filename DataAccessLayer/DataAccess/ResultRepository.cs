
using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    
    public class ResultRepository:IResultRepository
    {
        private readonly string connectionString;
        public ResultRepository(IConfiguration configuration) 
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<Report> ViewReport() {
            List<Report> reports = new List<Report>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ViewReports", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Report report = new Report
                            {
                                Report_Id = reader["Report_Id"].ToString(),
                                Customer_Name = reader["Customer_Name"].ToString(),
                                Dob = Convert.ToDateTime(reader["Dob"]),
                                Email_Id = reader["Email_Id"].ToString(),
                                Mobile_Number = Convert.ToInt64(reader["Mobile_Number"]),
                                Doctor_name = reader["Doctor_Name"].ToString(),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                Result = reader["Result"].ToString(),
                                Nomination_details_id = reader["Nomination_details_id"].ToString()
                            };



                            reports.Add(report);
                        }
                    }

                }
                return (reports);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
