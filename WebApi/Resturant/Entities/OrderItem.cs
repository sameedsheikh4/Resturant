using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal? OfferPercent { get; set; }
        public decimal? OfferAmount { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal FinalPrice { get; set; }
        public string Instructions { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual StoreOrder Order { get; set; }
    }
}
