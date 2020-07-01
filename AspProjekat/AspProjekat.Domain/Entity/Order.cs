using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Domain.Entity
{
    public class Order : Entity
    {
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int UserId { get; set; }
        
        public virtual User User { get; set; }
        public virtual ICollection<OrderInfo> OrderInfo { get; set; } = new HashSet<OrderInfo>();
    }

    public enum OrderStatus
    {
        Recieved,
        Delivered,
        Canceled
    }
}
