using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class ReviewResponse
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int? StarRating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ProductResponse ProductResponse { get; set; }
        public virtual UserResponse UserResponse { get; set; }
    }
}
