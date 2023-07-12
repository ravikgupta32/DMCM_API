using DataAccessLayer.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.Services.Login
{
    public class ServiceLogin:IServiceLogin
    {
        private readonly ILoginRepository _iLoginRepository;
        public ServiceLogin(ILoginRepository iLoginRepository)
        {
            _iLoginRepository = iLoginRepository;
        }

        public string Authenticate(string userId, string password)
        {
                // Verify the user from the users table
                bool isUserValid = _iLoginRepository.VerifyUserInCustomerTable(userId,password)|| _iLoginRepository.VerifyUserInDoctorTable(userId,password);

                if (!isUserValid)
                {
                    // Return null or throw an exception indicating authentication failure
                    return "User Does not exists";
                }
                string role = _iLoginRepository.GetUserRole(userId);
                string token = _iLoginRepository.GenerateJwtToken(userId, role);

                return token;
            

        }
        
    }
}
