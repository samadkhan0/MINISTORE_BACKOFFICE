using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Models;
using App.Core.Services;
using App.Core.Utilities;

namespace App.Core.Contracts
{
    public  interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(String id);
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(string id);
        public List<Order> GetCustomerId(string customerId);

        public List<Order> GetByStatus(OrderStatusEnum status);

    }
}
