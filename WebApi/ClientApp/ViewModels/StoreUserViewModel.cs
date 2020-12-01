using System;
using System.Collections.Generic;

namespace ClientApp.ViewModels
{
    public class StoreUserViewModel
    {
        public string UserId { get; set; }
        public int StoreId { get; set; }
        public DateTime? InvitationDatetime { get; set; }
        public DateTime? ActivationDatetime { get; set; }
        public DateTime? DeactivationDatetime { get; set; }
        public int BrandId { get; set; }

        public BrandViewModel Brand { get; set; }
        public StoreViewModel Store { get; set; }
        public UserViewModel User { get; set; }
    }
}
