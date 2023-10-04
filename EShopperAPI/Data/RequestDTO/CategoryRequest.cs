using EShopperAPI.Models;
using System;
using System.Collections.Generic;

namespace EShopperAPI.Data.RequestDTO
{
    public partial class CategoryRequest
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
