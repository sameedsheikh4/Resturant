using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class UserViewModel
    {
        public string UserId { get; set; }
        public byte Type { get; set; }

        public List<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public List<RiderViewModel> Rider { get; set; }
        public List<StoreOrderViewModel> StoreOrder { get; set; }
        public List<StoreUserViewModel> StoreUser { get; set; }
    }
}
