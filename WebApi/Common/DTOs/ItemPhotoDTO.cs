﻿using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class ItemPhotoDTO
    {
        public int ItemPhotoId { get; set; }
        public int ItemId { get; set; }
        public string Location { get; set; }
        public byte IsPrimary { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual ItemDTO Item { get; set; }
    }
}
