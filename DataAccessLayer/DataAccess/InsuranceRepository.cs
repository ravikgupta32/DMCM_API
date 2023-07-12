
using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class InsuranceRepository:IInsuranceRepository
    {
        private readonly string connectionString;
        public InsuranceRepository(IConfiguration configuration) 
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");

        }
        public List<Agent> GetAgentDetails()
        {
            List<Agent> agents = new List<Agent>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetInsuranceAgent", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                    
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Agent agent = new Agent
                            {
                                Agent_id = reader["Agent_Id"].ToString(),
                                Agent_name = reader["Agent_name"].ToString(),
                                Street_address = reader["Street_address"].ToString(),
                                Mobile_number =reader["Mobile_number"].ToString(),
                                City = reader["City"].ToString(),
                                State = reader["State"].ToString(),
                                Pincode = Convert.ToInt32(reader["Pincode"])
                            };
                            agents.Add(agent);
                        }
                    }
                    return agents;
                
            }
        }
        public void InsertNomination(Nomination nomination)
        {
            using (var connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("InsertNominationDetails", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                    command.Parameters.AddWithValue("@Name", nomination.Name);
                    command.Parameters.AddWithValue("@DOB", nomination.DOB);
                    command.Parameters.AddWithValue("@Email_id", nomination.Email_id);
                    command.Parameters.AddWithValue("@Mobile_number", nomination.Mobile_number);
                    command.Parameters.AddWithValue("@Country", nomination.Country);
                    command.Parameters.AddWithValue("@City_Name", nomination.City_Name);
                    command.Parameters.AddWithValue("@State", nomination.State);
                    command.Parameters.AddWithValue("@Pin_code", nomination.Pin_code);
                    command.Parameters.AddWithValue("@Healthplan_id", nomination.Healthplan_id);

                    connection.Open();
                    command.ExecuteNonQuery();
                
            }
        }



    }
}
