using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class StoreViewModel
    {
        public StoreViewModel()
        {
            Menu = new HashSet<MenuViewModel>();
            MenuItem = new HashSet<MenuItemViewModel>();
            //Offer = new HashSet<OfferDTO>();
            Rider = new HashSet<RiderViewModel>();
            StoreOrder = new HashSet<StoreOrderViewModel>();
            StoreUser = new HashSet<StoreUserViewModel>();
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

        public virtual BrandViewModel Brand { get; set; }
        public virtual CityViewModel City { get; set; }
        public virtual CountryViewModel Country { get; set; }
        public virtual ICollection<MenuViewModel> Menu { get; set; }
        public virtual ICollection<MenuItemViewModel> MenuItem { get; set; }
        //public virtual ICollection<OfferDTO> Offer { get; set; }
        public virtual ICollection<RiderViewModel> Rider { get; set; }
        public virtual ICollection<StoreOrderViewModel> StoreOrder { get; set; }
        public virtual ICollection<StoreUserViewModel> StoreUser { get; set; }
    }
}
