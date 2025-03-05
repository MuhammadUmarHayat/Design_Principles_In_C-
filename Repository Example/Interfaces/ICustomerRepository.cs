using RepExp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepExp1.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }
}
