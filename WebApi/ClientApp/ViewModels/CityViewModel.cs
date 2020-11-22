using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class CityViewModel
    {
        public CityViewModel()
        {
            DeliveryAddress = new HashSet<DeliveryAddressViewModel>();
            Store = new HashSet<StoreViewModel>();
        }

        public int CityId { get; set; }
        public int CountryId { get; set; }

        public virtual CountryViewModel Country { get; set; }
        public virtual ICollection<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public virtual ICollection<StoreViewModel> Store { get; set; }
    }
}
