using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class MenuCategoryPhoto
    {
        public int MenuCategoryPhotoId { get; set; }
        public int MenuCategoryId { get; set; }
        public string Location { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }

        public virtual MenuCategory MenuCategory { get; set; }
    }
}
