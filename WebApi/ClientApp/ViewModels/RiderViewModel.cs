using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class RiderViewModel
    {
        public int RiderId { get; set; }
        public int StoreId { get; set; }
        public string UserId { get; set; }

        public StoreViewModel Store { get; set; }
        public UserViewModel User { get; set; }
        public List<OrderRiderViewModel> OrderRider { get; set; }
    }
}
