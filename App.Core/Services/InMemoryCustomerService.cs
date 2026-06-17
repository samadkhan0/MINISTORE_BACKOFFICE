using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Core.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();

        public InMemoryCustomerService()
        {
            GenerateFakeCustomers();
        }

        Customer ICustomerService.Add(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            customer.Id = "c_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            _customers.Add(customer);
            return customer;
        }

        bool ICustomerService.Delete(string id)
        {
            int removed = _customers.RemoveAll(c => c.Id == id);
            return removed > 0;
        }

        List<Customer> ICustomerService.GetAll()
        {
            return _customers.OrderBy(c => c.Name).ToList();
        }

        Customer ICustomerService.GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        List<Customer> ICustomerService.Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return _customers.ToList();

            return _customers.Where(c =>
                c.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Email.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.Phone.Contains(query, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        bool ICustomerService.Update(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing == null) return false;

            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            existing.Address = customer.Address;
            existing.Status = customer.Status;
            return true;
        }

        private void GenerateFakeCustomers()
        {
            _customers.Add(new Customer
            {
                Id = "c_AAA001",
                Name = "Ali Hassan",
                Email = "ali@email.com",
                Phone = "0300-1234567",
                Address = "Lahore",
                Status = CustomerStatus.Active
            });

            _customers.Add(new Customer
            {
                Id = "c_BBB002",
                Name = "Sara Khan",
                Email = "sara@email.com",
                Phone = "0311-7654321",
                Address = "Karachi",
                Status = CustomerStatus.Active
            });

            _customers.Add(new Customer
            {
                Id = "c_CCC003",
                Name = "Usman Tariq",
                Email = "usman@email.com",
                Phone = "0321-9876543",
                Address = "Islamabad",
                Status = CustomerStatus.Inactive
            });
        }
    }
}