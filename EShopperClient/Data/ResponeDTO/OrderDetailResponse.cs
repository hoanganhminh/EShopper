using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class OrderDetailResponse
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual OrderResponse OrderResponse { get; set; }
        public virtual ProductResponse ProductResponse { get; set; }
    }
}
