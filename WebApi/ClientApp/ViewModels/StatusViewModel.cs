using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class StatusViewModel
    {
        public StatusViewModel()
        {
            OrderStatus = new HashSet<OrderStatusViewModel>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatusViewModel> OrderStatus { get; set; }
    }
}
