using System;
using System.Collections.Generic;

namespace EShopperAPI.Data.RequestDTO
{
    public partial class UserResponse
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public virtual List<OrderResponse> OrderResponses { get; set; }
        public virtual List<ReviewResponse> ReviewResponses { get; set; }
    }
}
