using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            OfferItem = new HashSet<OfferItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public int MenuItemId { get; set; }
        public int StoreId { get; set; }
        public int ItemId { get; set; }
        public int MenuId { get; set; }
        public int MenuCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsOutOfStock { get; set; }
        public bool IsActive { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public Item Item { get; set; }
        public Menu Menu { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OfferItem> OfferItem { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
