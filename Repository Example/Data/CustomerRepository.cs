using RepExp1.Entities;
using RepExp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepExp1.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new()
        {
            new Customer { Id = 1, Name = "Umar Hayat" },
            new Customer { Id = 2, Name = "Momal Umar" },
             new Customer { Id = 3, Name = "Muhammad Ubaidur rhman" }
        };
        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

    }
}
