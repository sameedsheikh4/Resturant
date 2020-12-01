using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class StoreViewModel
    {
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

        public BrandViewModel Brand { get; set; }
        public CityViewModel City { get; set; }
        public CountryViewModel Country { get; set; }
        public List<MenuViewModel> Menu { get; set; }
        public List<MenuItemViewModel> MenuItem { get; set; }
        //public virtual ICollection<OfferDTO> Offer { get; set; }
        public List<RiderViewModel> Rider { get; set; }
        public List<StoreOrderViewModel> StoreOrder { get; set; }
        public List<StoreUserViewModel> StoreUser { get; set; }
    }
}
