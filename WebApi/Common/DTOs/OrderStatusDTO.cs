using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class OrderStatusDTO
    {
        public int OrderStatusId { get; set; }
        public int OrderId { get; set; }
        public int StatusId { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Date { get; set; }

        public virtual StoreOrderDTO Order { get; set; }
        public virtual StatusDTO Status { get; set; }
    }
}
