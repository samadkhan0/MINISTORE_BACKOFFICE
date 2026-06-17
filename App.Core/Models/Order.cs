using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using App.Core.Utilities;

namespace App.Core.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatusEnum Status { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public List<OrderItem> Items { get; set; }
        public Order()
        {
            Id = "0_" + Guid.NewGuid().ToString("N").Substring(0, 9);
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status = OrderStatusEnum.Pending;
        }
        public decimal TotalAmount()
        {
            return Items.Sum(Item => Item.Total());
        }

        
      
    }
}
