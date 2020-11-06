using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class City
    {
        public City()
        {
            DeliveryAddress = new HashSet<DeliveryAddress>();
            Store = new HashSet<Store>();
        }

        public int CityId { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
