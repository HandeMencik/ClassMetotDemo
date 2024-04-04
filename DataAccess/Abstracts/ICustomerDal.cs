using Methods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.DataAccess.Abstracts
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        void Add(Customer customer);       
        void Remove(Customer customer);

    }
}
