using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class OrderRiderViewModel
    {
        public int RiderId { get; set; }
        public int OrderId { get; set; }
        public DateTime AssignmentDatetime { get; set; }
        public DateTime? JourneyStartTime { get; set; }
        public DateTime? JourneyEndTime { get; set; }
        public string Comment { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public StoreOrderViewModel Order { get; set; }
        public RiderViewModel Rider { get; set; }
    }
}
