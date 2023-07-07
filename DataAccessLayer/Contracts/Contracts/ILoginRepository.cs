using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Contracts
{
    public  interface ILoginRepository
    {
        public string GetUserRole(string userId);
        public bool VerifyUser(string userId, string password);
       
        public string GenerateJwtToken(string userId,string role);




    }

}
