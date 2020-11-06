using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Item
    {
        public Item()
        {
            ItemPhoto = new HashSet<ItemPhoto>();
            MenuItem = new HashSet<MenuItem>();
        }

        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOutOfStock { get; set; }
        public bool IsActive { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<ItemPhoto> ItemPhoto { get; set; }
        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
