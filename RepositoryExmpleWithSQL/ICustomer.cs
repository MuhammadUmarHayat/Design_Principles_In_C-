using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExmple1
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetById(int id);
        public Boolean addCustomer(Customer customer);
        public Boolean updateCustomer(Customer customer);
        public Boolean deleteCustomer(int id);
    }
}
