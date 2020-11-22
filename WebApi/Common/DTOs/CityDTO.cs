using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class CityDTO
    {
        public CityDTO()
        {
            DeliveryAddress = new HashSet<DeliveryAddressDTO>();
            Store = new HashSet<StoreDTO>();
        }

        public int CityId { get; set; }
        public int CountryId { get; set; }

        public virtual CountryDTO Country { get; set; }
        public virtual ICollection<DeliveryAddressDTO> DeliveryAddress { get; set; }
        public virtual ICollection<StoreDTO> Store { get; set; }
    }
}
