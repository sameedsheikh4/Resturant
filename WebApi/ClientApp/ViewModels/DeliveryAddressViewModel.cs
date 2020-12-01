using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class DeliveryAddressViewModel
    {
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

        public CityViewModel City { get; set; }
        public CountryViewModel Country { get; set; }
        public UserViewModel User { get; set; }
        public List<StoreOrderViewModel> StoreOrder { get; set; }
    }
}
