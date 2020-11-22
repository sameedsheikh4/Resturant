using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class StoreOrderViewModel
    {
        public StoreOrderViewModel()
        {
            OrderItem = new HashSet<OrderItemViewModel>();
            OrderRider = new HashSet<OrderRiderViewModel>();
            OrderStatus = new HashSet<OrderStatusViewModel>();
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

        public virtual UserViewModel Customer { get; set; }
        public virtual DeliveryAddressViewModel DeliveryAddress { get; set; }
        public virtual StoreViewModel Store { get; set; }
        public virtual ICollection<OrderItemViewModel> OrderItem { get; set; }
        public virtual ICollection<OrderRiderViewModel> OrderRider { get; set; }
        public virtual ICollection<OrderStatusViewModel> OrderStatus { get; set; }
    }
}
