using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public int MenuId { get; set; }
        public int StoreId { get; set; }
        public bool IsActive { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }
}
