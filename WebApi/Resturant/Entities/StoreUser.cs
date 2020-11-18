using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class StoreUser
    {
        public string UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime? InvitationDatetime { get; set; }
        public DateTime? ActivationDatetime { get; set; }
        public DateTime? DeactivationDatetime { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
