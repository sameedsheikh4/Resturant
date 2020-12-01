using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class CountryViewModel
    {

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }

        public List<CityViewModel> City { get; set; }
        public List<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public List<StoreViewModel> Store { get; set; }
    }
}
