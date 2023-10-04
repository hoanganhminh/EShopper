using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class ReviewRequest
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int? StarRating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
