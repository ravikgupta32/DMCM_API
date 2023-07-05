using BusinessAccessLayer.Models;
using Microsoft.Data.SqlClient;



namespace DataAccessLayer.DataAccess
{
    public class HealthPlanRepository
    {
        private readonly string connectionString = "Data Source=LTIN196430\\SQLEXPRESS;Initial Catalog=dmcm;Integrated Security=True;TrustServerCertificate=True";
        public List<string> GetPlanNames() {
            List <string> plan_names = new List<string>();
            using(var connection = new SqlConnection(connectionString))
            { 
                string query = "Select HealthPlan_name from HealthPlan_Details";
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["HealthPlan_name"].ToString();
                            plan_names.Add(name);
                        }
                       
                    }
                }
                return plan_names;
            }
        }
        
        public List<HealthPlan> GetHealthPlanDetails(string PlanName)
        {
            List<HealthPlan> plandetail = new List<HealthPlan>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM HealthPlan_Details WHERE HealthPlan_name = @PlanName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlanName", PlanName);  
                    connection.Open();
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
        }
     



    }
}


