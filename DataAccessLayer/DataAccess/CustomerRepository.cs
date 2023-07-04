using DMCM_API.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace DataAccessLayer.DataAccess
{
    public class CustomerRepository
    {
        private readonly string connectionString = "Data Source=LTIN196430\\SQLEXPRESS;Initial Catalog=dmcm;Integrated Security=True;TrustServerCertificate=True";

        public Customer AddCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Customer_Details (User_id,Password, Name, Email_id, Dob,Mobile) " +
                "VALUES (@User_id,@Password,@Name, @Email_id, @Dob, @Mobile)";



                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@User_id", customer.Userid);
                command.Parameters.AddWithValue("@Password",customer.Password);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Email_id", customer.Email);
                command.Parameters.AddWithValue("@Dob", customer.Dob);
                
                

                command.ExecuteNonQuery();
            }
            return customer;
        }
        public List<Customer> GetCustomerDetails()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customer_Details";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer 
                            {
                                Userid = reader["User_Id"].ToString(),
                                Password = reader["Password"].ToString(),
                                Name = reader["Name"].ToString(),
                                Dob = Convert.ToDateTime(reader["Dob"]),
                                Email = reader["Email_Id"].ToString(),
                                Mobile = Convert.ToInt64(reader["Mobile"]),
                                Report_id = reader["Report_id"].ToString(),
                                Nomination_details_id = Convert.ToInt32(reader["Nomination_details_id"]),
                                Agent_id = reader["Agent_id"].ToString()



                            };
                            customers.Add(customer);
                        }
                    }
                    return customers;
                }
            }
        }
    }
}
