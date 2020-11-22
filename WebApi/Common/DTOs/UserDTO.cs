using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class UserDTO
    {
        public UserDTO()
        {
            DeliveryAddress = new HashSet<DeliveryAddressDTO>();
            Rider = new HashSet<RiderDTO>();
            StoreOrder = new HashSet<StoreOrderDTO>();
            StoreUser = new HashSet<StoreUserDTO>();
        }

        public string UserId { get; set; }
        public byte Type { get; set; }

        public virtual ICollection<DeliveryAddressDTO> DeliveryAddress { get; set; }
        public virtual ICollection<RiderDTO> Rider { get; set; }
        public virtual ICollection<StoreOrderDTO> StoreOrder { get; set; }
        public virtual ICollection<StoreUserDTO> StoreUser { get; set; }
    }
}
