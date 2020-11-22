using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class RiderViewModel
    {
        public RiderViewModel()
        {
            OrderRider = new HashSet<OrderRiderViewModel>();
        }

        public int RiderId { get; set; }
        public int StoreId { get; set; }
        public string UserId { get; set; }

        public virtual StoreViewModel Store { get; set; }
        public virtual UserViewModel User { get; set; }
        public virtual ICollection<OrderRiderViewModel> OrderRider { get; set; }
    }
}
