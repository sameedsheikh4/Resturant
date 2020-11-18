using System;
using System.Collections.Generic;

namespace WebAPI.Entities
{
    public partial class UserRefreshTokens
    {
        public string UserId { get; set; }
        public string RefreshToken { get; set; }
        public DateTime TokenDate { get; set; }

        public virtual Aspnetusers User { get; set; }
    }
}
