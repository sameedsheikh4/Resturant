using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class OrderRider
    {
        public int RiderId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public virtual StoreOrder Order { get; set; }
        public virtual Rider Rider { get; set; }
    }
}
