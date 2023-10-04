using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class OrderResponse
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public virtual UserResponse UserResponse { get; set; }
        public virtual List<OrderDetailResponse> OrderDetailResponses { get; set; }
    }
}
