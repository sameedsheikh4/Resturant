using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class RiderDTO
    {
        public RiderDTO()
        {
            OrderRider = new HashSet<OrderRiderDTO>();
        }

        public int RiderId { get; set; }
        public int StoreId { get; set; }
        public string UserId { get; set; }

        public virtual StoreDTO Store { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<OrderRiderDTO> OrderRider { get; set; }
    }
}
