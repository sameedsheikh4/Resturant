using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class StoreDTO
    {
        public StoreDTO()
        {
            Menu = new HashSet<MenuDTO>();
            MenuItem = new HashSet<MenuItemDTO>();
            //Offer = new HashSet<OfferDTO>();
            Rider = new HashSet<RiderDTO>();
            StoreOrder = new HashSet<StoreOrderDTO>();
            StoreUser = new HashSet<StoreUserDTO>();
        }

        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal ServiceDistance { get; set; }
        public string StreetAddress { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string GooglePin { get; set; }
        public string Uri { get; set; }
        public byte IsClosed { get; set; }
        public byte IsActive { get; set; }
        public DateTime DeactivationDate { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual BrandDTO Brand { get; set; }
        public virtual CityDTO City { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual ICollection<MenuDTO> Menu { get; set; }
        public virtual ICollection<MenuItemDTO> MenuItem { get; set; }
        //public virtual ICollection<OfferDTO> Offer { get; set; }
        public virtual ICollection<RiderDTO> Rider { get; set; }
        public virtual ICollection<StoreOrderDTO> StoreOrder { get; set; }
        public virtual ICollection<StoreUserDTO> StoreUser { get; set; }
    }
}
