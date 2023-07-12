using DataAccessLayer.Contracts.Contracts;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class LoginRepository:ILoginRepository
    {
        
        
        public IConfiguration _config;
        private readonly string connectionString;
        public LoginRepository(IConfiguration config) { 
            _config = config;
            connectionString = _config.GetConnectionString("DefaultConnection");
        }
       

        public string GetUserRole(string userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Get the user role from the databasestring
                string query = "SELECT 'Customer' as Role FROM Customer_details WHERE User_Id = @UserId UNION ALL SELECT 'Doctor'  as Role from doctor_details where doctor_id = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    string role = (string)command.ExecuteScalar();
                    return role;
                }

            }
        }
        
        public bool VerifyUserInCustomerTable(string userId, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists in the database
                string query = "SELECT COUNT(*) FROM Customer_details WHERE User_Id = @UserId AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public bool VerifyUserInDoctorTable(string userId, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists in the database
                string query = "SELECT COUNT(*) FROM doctor_details WHERE doctor_id = @UserId AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public string GenerateJwtToken(string userId,string role)
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

    }
}
