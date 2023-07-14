using DataAccessLayer.Contracts;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.customer
{
    
    public class ServiceCustomer : IServiceCustomer
    
    {
        public readonly ICustomerRepository _icustomerRepository;
        public ServiceCustomer(ICustomerRepository customerRepository) { _icustomerRepository = customerRepository; }
        

        public string AddCustomer(Customer customer)
        {
            try
            {

                return _icustomerRepository.AddCustomer(customer);
            }

            catch (Exception) 
            {
                throw;
            }
        }

       
    }


}
