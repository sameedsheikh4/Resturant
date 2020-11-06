using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Status
    {
        public Status()
        {
            OrderStatus = new HashSet<OrderStatus>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatus> OrderStatus { get; set; }
    }
}
