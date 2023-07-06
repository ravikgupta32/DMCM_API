using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.customer
{
    public interface IServiceCustomer
    {
        public string AddCustomer(Customer customer);
        public List<Customer> GetCustomerDetail();
    }
}
