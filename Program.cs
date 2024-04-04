// See https://aka.ms/new-console-template for more information

using Methods;
using Methods.Businnes;
using Methods.DataAccess.Concretes;
using Methods.Entities;

CustomerManager customerManager = new (new CustomerDal());
List<Customer> customers= customerManager.GetAll();

for (int i = 0; i < customers.Count; i++)
{
    Console.WriteLine(customers[i].Id+" "+customers[i].FirstName+" " + customers[i].LastName+" " + customers[i].CustomerNumber);
}






