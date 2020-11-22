using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class CountryViewModel
    {
        public CountryViewModel()
        {
            City = new HashSet<CityViewModel>();
            DeliveryAddress = new HashSet<DeliveryAddressViewModel>();
            Store = new HashSet<StoreViewModel>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }

        public virtual ICollection<CityViewModel> City { get; set; }
        public virtual ICollection<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public virtual ICollection<StoreViewModel> Store { get; set; }
    }
}
