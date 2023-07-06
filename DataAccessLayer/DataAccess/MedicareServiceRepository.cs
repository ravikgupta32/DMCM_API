using DataAccessLayer.Contracts.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class MedicareServiceRepository:IMedicareServiceRepository
    {
        private readonly string connectionString = "Data Source=LTIN196430\\SQLEXPRESS;Initial Catalog=dmcm;Integrated Security=True;TrustServerCertificate=True";

        public List<string> GetPlanNames()
        {
            List<string> plan_names = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "Select Service_Name from medicareservice_details";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Service_Name"].ToString();
                            plan_names.Add(name);
                        }

                    }
                }
                
            }
            return plan_names;
        }
        public List<medservice> GetPlanDetails(string planName)
        {
            List<medservice> plandetail = new List<medservice>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM medicareservice_details WHERE Service_Name = @PlanName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlanName", planName);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medservice detail = new medservice
                            {
                                Service_Id = Convert.ToInt32(reader["Service_Id"]),
                                Service_Name = reader["Service_Name"].ToString(),
                                Service_Features = reader["Service_Features"].ToString(),
                                Service_Benefits = reader["Service_Benefits"].ToString(),
                                Service_Parameters =reader["Service_Parameters"].ToString(),
                            };
                            plandetail.Add(detail);
                        }
                    }
                    return plandetail;
                }
            }
        }
    }
}    

