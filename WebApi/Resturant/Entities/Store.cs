using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Store
    {
        public Store()
        {
            Menu = new HashSet<Menu>();
            MenuItem = new HashSet<MenuItem>();
            Offer = new HashSet<Offer>();
            Rider = new HashSet<Rider>();
            StoreOrder = new HashSet<StoreOrder>();
            StoreUser = new HashSet<StoreUser>();
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
        public bool IsClosed { get; set; }
        public bool IsActive { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<MenuItem> MenuItem { get; set; }
        public virtual ICollection<Offer> Offer { get; set; }
        public virtual ICollection<Rider> Rider { get; set; }
        public virtual ICollection<StoreOrder> StoreOrder { get; set; }
        public virtual ICollection<StoreUser> StoreUser { get; set; }
    }
}
