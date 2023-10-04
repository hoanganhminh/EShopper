namespace EShopperClient.Models
{
    public class ViewModel
    {
        public List<ProductResponse>? productResponses { get; set; }
        public List<UserResponse>? userResponses { get; set; }
        public List<OrderDetailResponse>? orderDetailResponses { get; set; }
        public List<OrderResponse>? orderResponses { get; set; }
        public List<ReviewResponse>? reviewResponses { get; set; }
        public List<CategoryResponse>? categoryResponses { get; set; }
    }
}
