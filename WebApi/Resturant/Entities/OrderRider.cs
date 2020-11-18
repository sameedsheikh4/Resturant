using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class OrderRider
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

        public virtual StoreOrder Order { get; set; }
        public virtual Rider Rider { get; set; }
    }
}
