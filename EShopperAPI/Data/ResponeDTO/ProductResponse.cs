using System;
using System.Collections.Generic;

namespace EShopperAPI.Data.RequestDTO
{
    public partial class ProductResponse
    {
        public int ProductId { get; set; }
        public int? ParentProductId { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public string Collection { get; set; }
        public decimal? DiscountPercentage { get; set; }

        public virtual CategoryResponse CategoryResponse { get; set; }
        //public virtual List<OrderDetailResponse> OrderDetailResponses { get; set; }
        //public virtual List<ReviewResponse> ReviewResponses { get; set; }
    }
}
