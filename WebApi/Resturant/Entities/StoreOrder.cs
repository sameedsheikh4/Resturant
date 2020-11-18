using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class StoreOrder
    {
        public StoreOrder()
        {
            OrderItem = new HashSet<OrderItem>();
            OrderRider = new HashSet<OrderRider>();
            OrderStatus = new HashSet<OrderStatus>();
        }

        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public int PhoneNumber { get; set; }
        public int DeliveryAddressId { get; set; }
        public decimal DeliveryCharge { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal NetPayable { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Remarks { get; set; }

        public virtual User Customer { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual ICollection<OrderRider> OrderRider { get; set; }
        public virtual ICollection<OrderStatus> OrderStatus { get; set; }
    }
}
