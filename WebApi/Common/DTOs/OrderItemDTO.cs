﻿using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal? OfferPercent { get; set; }
        public decimal? OfferAmount { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ArchivedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal FinalPrice { get; set; }
        public string Instructions { get; set; }

        public virtual MenuItemDTO MenuItem { get; set; }
        public virtual StoreOrderDTO Order { get; set; }
    }
}
