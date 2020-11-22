using System;
using System.Collections.Generic;

namespace Common.DTOs
{
    public partial class StoreUserDTO
    {
        public string UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime? InvitationDatetime { get; set; }
        public DateTime? ActivationDatetime { get; set; }
        public DateTime? DeactivationDatetime { get; set; }
        public int BrandId { get; set; }

        public virtual BrandDTO Brand { get; set; }
        public virtual StoreDTO Store { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
