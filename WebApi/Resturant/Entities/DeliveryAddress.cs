using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class DeliveryAddress
    {
        public DeliveryAddress()
        {
            StoreOrder = new HashSet<StoreOrder>();
        }

        public int DeliveryAddressId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string StreetAddress { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
    }
}
