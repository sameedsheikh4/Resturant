using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.DTOs
{
    public class MenuCategoryDTO
    {

        public int MenuCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }


        public IEnumerable<MenuCategoryPhotoDTO> MenuCategoryPhoto { get; set; }
    }
}
