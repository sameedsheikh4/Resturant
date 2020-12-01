using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class StatusViewModel
    {
        public int StatusId { get; set; }
        public string Description { get; set; }

        public List<OrderStatusViewModel> OrderStatus { get; set; }
    }
}
