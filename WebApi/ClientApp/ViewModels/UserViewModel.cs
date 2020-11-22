using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class UserViewModel
    {
        public UserViewModel()
        {
            DeliveryAddress = new HashSet<DeliveryAddressViewModel>();
            Rider = new HashSet<RiderViewModel>();
            StoreOrder = new HashSet<StoreOrderViewModel>();
            StoreUser = new HashSet<StoreUserViewModel>();
        }

        public string UserId { get; set; }
        public byte Type { get; set; }

        public virtual ICollection<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public virtual ICollection<RiderViewModel> Rider { get; set; }
        public virtual ICollection<StoreOrderViewModel> StoreOrder { get; set; }
        public virtual ICollection<StoreUserViewModel> StoreUser { get; set; }
    }
}
