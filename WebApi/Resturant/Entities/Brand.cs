using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Store = new HashSet<Store>();
            StoreUser = new HashSet<StoreUser>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public short? Phone { get; set; }
        public short Mobile { get; set; }
        public short? WhatsApp { get; set; }
        public string FacebookId { get; set; }
        public string TwitterId { get; set; }
        public bool IsActive { get; set; }
        public decimal MinimumOrder { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal FreeDeliveryAmount { get; set; }
        public short DeliveryMinutes { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string TaxEntity { get; set; }
        public decimal TaxPercent { get; set; }
        public string OperatingHoursText { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime Activation_Date { get; set; }
        public DateTime Deactivation_Date { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
        public DateTime Archived_Date { get; set; }
        public virtual ICollection<Store> Store { get; set; }
        public virtual ICollection<StoreUser> StoreUser { get; set; }
    }
}