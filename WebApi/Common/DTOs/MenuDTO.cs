using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.DTOs
{
    public partial class MenuDTO
    {
        public int MenuId { get; set; }
        [Required]
        public int StoreId { get; set; }
        public DateTime PublishStateTime { get; set; }
        public DateTime PublishEndTime { get; set; }
        public byte IsActive { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }
    }
}
