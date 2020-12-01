using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class OrderStatusViewModel
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

        public StoreOrderViewModel Order { get; set; }
        public StatusViewModel Status { get; set; }
    }
}
