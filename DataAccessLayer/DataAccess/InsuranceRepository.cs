
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;


namespace DataAccessLayer.DataAccess
{
    public class InsuranceRepository
    {
        private readonly string connectionString = "Data Source=LTIN196430\\SQLEXPRESS;Initial Catalog=dmcm;Integrated Security=True;TrustServerCertificate=True";
        public List<Agent> GetAgentDetails()
        {
            List<Agent> agents = new List<Agent>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Insurance_Agent";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Agent agent = new Agent
                            {
                                Agent_id = reader["Agent_Id"].ToString(),
                                Agent_name = reader["Agent_name"].ToString(),
                                Street_address = reader["Street_address"].ToString(),
                                Mobile_number = Convert.ToInt64(reader["Mobile_number"]),
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
        }
        public void InsertNomination(Nomination nomination)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Nomination_Details (Name, DOB, Email_id, Mobile_number, Country,State,City_Name, Pin_code, Healthplan_id) " +
                               "VALUES (@Name, @DOB, @Email_id, @Mobile_number, @Country,@State, @City_Name, @Pin_code, @Healthplan_id)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
}
