using System;
using System.Collections.Generic;

namespace EShopperClient.Models
{
    public partial class CategoryRequest
    {
        public CategoryRequest()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
