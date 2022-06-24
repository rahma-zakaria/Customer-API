using DomainLayer.Models;
using ReprositryLayer.Reprositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IReprositry<Customer> _reprositry;
        public CustomerService(IReprositry<Customer> reprositry)
        {
            _reprositry = reprositry;
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            _reprositry.Remove(customer);
            _reprositry.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _reprositry.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _reprositry.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _reprositry.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _reprositry.Update(customer);
        }
    }
}
