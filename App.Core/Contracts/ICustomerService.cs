using App.Core.Models;
using App.Core.Utilities;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        bool Update(Customer customer);
        bool Delete(string id);
        Customer GetById(string id);
        List<Customer> GetAll();
        List<Customer> Search(string query);
    }
}