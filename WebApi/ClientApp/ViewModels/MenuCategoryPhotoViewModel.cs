using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class MenuCategoryPhotoViewModel
    {
        public int MenuCategoryPhotoId { get; set; }
        public int MenuCategoryId { get; set; }
        public string Location { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

    }
}
