using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class MenuCategory
    {
        public MenuCategory()
        {
            MenuCategoryPhoto = new HashSet<MenuCategoryPhoto>();
            MenuItem = new HashSet<MenuItem>();
        }

        public int MenuCategoryId { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual ICollection<MenuCategoryPhoto> MenuCategoryPhoto { get; set; }
        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
