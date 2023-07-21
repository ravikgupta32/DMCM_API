
using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class HealthPlanRepository:IHealthPlanRepository
    {
        private readonly string connectionString;
        public HealthPlanRepository(IConfiguration configuration) 
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public List<string> GetPlanNames() {

            List <string> plan_names = new List<string>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetHealthPlanNames", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["HealthPlan_name"].ToString();
                            plan_names.Add(name);
                        }


                    }
                    return plan_names;
                }
            } 
            catch (Exception )
            {
                throw;

            }
        }

        public List<HealthPlan> GetHealthPlanDetails(string PlanName)
        {
            List<HealthPlan> plandetail = new List<HealthPlan>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetHealthPlanDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PlanName", PlanName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HealthPlan detail = new HealthPlan
                            {
                                HealthPlan_name = reader["HealthPlan_name"].ToString(),
                                Details = reader["Details"].ToString(),
                                HealthPlan_price = Convert.ToDouble(reader["HealthPlan_price"]),
                                No_of_days = Convert.ToInt32(reader["No_of_days"]),
                            };
                            plandetail.Add(detail);
                        }
                    }
                    return plandetail;
                }
            }
            catch (Exception) 
            {
                throw;
            }
            }
        
     



    }
}


