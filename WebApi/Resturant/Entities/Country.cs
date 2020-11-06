using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            DeliveryAddress = new HashSet<DeliveryAddress>();
            Store = new HashSet<Store>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
