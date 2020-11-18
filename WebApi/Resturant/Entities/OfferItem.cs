using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class OfferItem
    {
        public int OfferItemId { get; set; }
        public int MenuItemId { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Amount { get; set; }
        public string ArchivedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public virtual MenuItem MenuItem { get; set; }
    }
}
