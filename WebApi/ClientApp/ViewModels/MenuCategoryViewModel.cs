using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientApp.ViewModels
{
    public class MenuCategoryViewModel
    {
        public int MenuCategoryId { get; set; }
        public int StoreId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }


        public List<MenuCategoryPhotoViewModel> MenuCategoryPhoto { get; set; }
    }
}
