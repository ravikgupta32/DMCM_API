
using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    
    public class ResultRepository:IResultRepository
    {
        private readonly string connectionString = "Data Source=LTIN196430\\SQLEXPRESS;Initial Catalog=dmcm;Integrated Security=True;TrustServerCertificate=True";
        public List<Report> ViewReport() {
            List<Report> reports = new List<Report>();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM view_reports";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();



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
                                Nomination_details_id = Convert.ToInt64(reader["Nomination_details_id"])
                            };



                            reports.Add(report);
                        }
                    }
                }
            }



            return (reports);

        }
    }
}
