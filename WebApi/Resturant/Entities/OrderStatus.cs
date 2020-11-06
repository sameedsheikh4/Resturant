using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public int OrderId { get; set; }
        public int StatusId { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public virtual StoreOrder Order { get; set; }
        public virtual Status Status { get; set; }
    }
}
