using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderDetailId { get; set; }
        public float Total { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
