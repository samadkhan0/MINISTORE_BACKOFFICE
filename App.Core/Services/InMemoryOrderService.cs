using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Utilities;

namespace App.Core.Services
{
    public class InMemoryOrderService : IOrderService
    {
        private List<Order> _orders;
        public InMemoryOrderService()
        {
            _orders = new List<Order>();
        }
         List<Order>IOrderService.GetAll()
        {
            return  _orders.ToList(); // your logic
        }

         Order IOrderService .GetById(string id)
        {
            return _orders.FirstOrDefault(order => order.Id == id);
        }

        void IOrderService.Add(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Order is null");
            _orders.Add(order);
        }

        public void Delete(string id)
        {
            // delete logic
        }

        List<Order>IOrderService. GetCustomerId(string customerId)
        {
            return _orders.Where(order => order.CustomerId == customerId).ToList();
        }

        List<Order> IOrderService.GetByStatus(OrderStatusEnum status)
        {
            return _orders.Where(order => order.Status == status).ToList();
        }
        void IOrderService.Update(Order order)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == order.Id);
            if(existing == null)
            {
                throw new Exception($"Order with Id : {order.Id} not found");
            }
            existing.CustomerId = order.CustomerId;
            existing.CustomerName = order.CustomerName;
            existing.OrderDate = order.OrderDate;
            existing.Status = order.Status;
            existing.PaymentMethod = order.PaymentMethod;
            existing.Items= order.Items;
        }
    }
}
