using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class CountryDTO
    {
        public CountryDTO()
        {
            City = new HashSet<CityDTO>();
            DeliveryAddress = new HashSet<DeliveryAddressDTO>();
            Store = new HashSet<StoreDTO>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }

        public virtual ICollection<CityDTO> City { get; set; }
        public virtual ICollection<DeliveryAddressDTO> DeliveryAddress { get; set; }
        public virtual ICollection<StoreDTO> Store { get; set; }
    }
}
