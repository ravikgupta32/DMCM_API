using DataAccessLayer.Contracts.Contracts;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class LoginRepository : ILoginRepository
    {


        public IConfiguration _config;
        private readonly string? connectionString;
        public LoginRepository(IConfiguration config) {
            _config = config;
            connectionString = _config.GetConnectionString("DefaultConnection");
        }
       
  
        public string GetUserRole(string userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                        connection.Open();
                        SqlCommand command = new SqlCommand("GetRole", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserId", userId);
                        string role = (string)command.ExecuteScalar();
                        return role;
                    

                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        public bool VerifyUserInCustomerTable(string userId, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the user exists in the database

                        SqlCommand command = new SqlCommand("VerifyUserInCustomerTable", connection) ;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Password", password);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    
                }
            }
            catch (Exception )

            {
                throw;
            }
        }

        public bool VerifyUserInDoctorTable(string userId, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("VerifyUserInDoctorTable", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;

                    // Check if the user exists in the database
                    /*string query = "SELECT COUNT(*) FROM doctor_details WHERE doctor_id = @UserId AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }*/
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public string GenerateJwtToken(string userId, string role)
        {
            try
            {
                var claims = new List<Claim>

           { new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
             new Claim(ClaimTypes.Role, role)
            };
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: credentials
                );
                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            catch (Exception)
            {
                throw;
            }


        }
    }

    
}
