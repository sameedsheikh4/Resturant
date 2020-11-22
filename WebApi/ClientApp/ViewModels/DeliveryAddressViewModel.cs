using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class DeliveryAddressViewModel
    {
        public DeliveryAddressViewModel()
        {
            StoreOrder = new HashSet<StoreOrderViewModel>();
        }

        public int DeliveryAddressId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string StreetAddress { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual CityViewModel City { get; set; }
        public virtual CountryViewModel Country { get; set; }
        public virtual UserViewModel User { get; set; }
        public virtual ICollection<StoreOrderViewModel> StoreOrder { get; set; }
    }
}
