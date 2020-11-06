using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class User
    {
        public User()
        {
            DeliveryAddress = new HashSet<DeliveryAddress>();
            Rider = new HashSet<Rider>();
            StoreOrder = new HashSet<StoreOrder>();
            StoreUser = new HashSet<StoreUser>();
        }

        public string UserId { get; set; }
        public byte Type { get; set; }

        public virtual ICollection<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual ICollection<Rider> Rider { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
        public virtual ICollection<StoreUser> StoreUser { get; set; }
    }
}
