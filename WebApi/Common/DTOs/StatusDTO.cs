using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class StatusDTO
    {
        public StatusDTO()
        {
            OrderStatus = new HashSet<OrderStatusDTO>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatusDTO> OrderStatus { get; set; }
    }
}
