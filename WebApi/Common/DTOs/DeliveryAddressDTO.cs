using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class DeliveryAddressDTO
    {
        public DeliveryAddressDTO()
        {
            StoreOrder = new HashSet<StoreOrderDTO>();
        }

        public int DeliveryAddressId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string StreetAddress { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual CityDTO City { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<StoreOrderDTO> StoreOrder { get; set; }
    }
}
