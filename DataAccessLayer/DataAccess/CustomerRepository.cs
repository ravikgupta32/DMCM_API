using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class CustomerRepository:ICustomerRepository
    {

        private readonly string connectionString;
        public CustomerRepository(IConfiguration configuration) {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public string AddCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertCustomerDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@User_id", customer.Userid);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Dob", customer.Dob);
                    command.Parameters.AddWithValue("@Email_id", customer.Email);
                    command.Parameters.AddWithValue("@Mobile", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", customer.Address);








                    command.ExecuteNonQuery();
                }
                return "Added customer successfully";
            }

            catch (Exception )
            {
                throw;
            }
        }
        
    }
}
