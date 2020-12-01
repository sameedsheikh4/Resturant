using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class CityViewModel
    {       
        public int CityId { get; set; }
        public int CountryId { get; set; }

        public CountryViewModel Country { get; set; }
        public List<DeliveryAddressViewModel> DeliveryAddress { get; set; }
        public List<StoreViewModel> Store { get; set; }
    }
}
