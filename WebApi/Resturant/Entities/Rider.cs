using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Rider
    {
        public Rider()
        {
            OrderRider = new HashSet<OrderRider>();
        }

        public int RiderId { get; set; }
        public int StoreId { get; set; }
        public string UserId { get; set; }

        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderRider> OrderRider { get; set; }
    }
}
