using Methods.DataAccess.Abstracts;
using Methods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.DataAccess.Concretes
{
    public class CustomerDal : ICustomerDal
    {
        List<Customer> customers;
        public CustomerDal() 
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Hande";
            customer1.LastName = "Mencik";
            customer1.CustomerNumber = 1001007;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Muhammet Fatih";
            customer2.LastName = "Aydın";
            customer2.CustomerNumber = 1002007;

         customers = new List<Customer> {customer1,customer2 };
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return customers;
        }

        public void Remove(Customer customer)
        {
           customers.Remove(customer);
        }

    
    }
}
