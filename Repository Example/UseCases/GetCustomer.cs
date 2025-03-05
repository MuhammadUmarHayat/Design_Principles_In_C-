using RepExp1.Entities;
using RepExp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepExp1.UseCases
{
    public class GetCustomer
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomer(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Execute(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }
}
