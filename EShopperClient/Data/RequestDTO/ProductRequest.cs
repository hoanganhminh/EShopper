using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class ProductRequest
    {
        public ProductRequest()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Reviews = new HashSet<Review>();
        }

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

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
