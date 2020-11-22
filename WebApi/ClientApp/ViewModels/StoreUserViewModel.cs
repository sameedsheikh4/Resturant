using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public partial class StoreUserViewModel
    {
        public string UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime? InvitationDatetime { get; set; }
        public DateTime? ActivationDatetime { get; set; }
        public DateTime? DeactivationDatetime { get; set; }
        public int BrandId { get; set; }

        public virtual BrandViewModel Brand { get; set; }
        public virtual StoreViewModel Store { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
