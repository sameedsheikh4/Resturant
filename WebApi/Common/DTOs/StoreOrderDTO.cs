using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class StoreOrderDTO
    {
        public StoreOrderDTO()
        {
            OrderItem = new HashSet<OrderItemDTO>();
            OrderRider = new HashSet<OrderRiderDTO>();
            OrderStatus = new HashSet<OrderStatusDTO>();
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

        public virtual UserDTO Customer { get; set; }
        public virtual DeliveryAddressDTO DeliveryAddress { get; set; }
        public virtual StoreDTO Store { get; set; }
        public virtual ICollection<OrderItemDTO> OrderItem { get; set; }
        public virtual ICollection<OrderRiderDTO> OrderRider { get; set; }
        public virtual ICollection<OrderStatusDTO> OrderStatus { get; set; }
    }
}
