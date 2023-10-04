using System;
using System.Collections.Generic;

namespace EShopperAPI.Data.RequestDTO
{
    public partial class CategoryResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<ProductResponse> ProductResponses { get; set; }
    }
}
