namespace EShopperClient.APIEndPoints
{
    public class APIEndPoints
    {
        public static readonly string DOMAIN_URL = "http://localhost:7088";

        public class ProductAPIEndPoints
        {
            public static readonly string PRODUCT_PATH = $"{DOMAIN_URL}/api/Product";
        }
        public class CategoryAPIEndPoints
        {
            public static readonly string CATEGORY_PATH = $"{DOMAIN_URL}/api/Category";
        }
        public class OrderAPIEndPoints
        {
            public static readonly string ORDER_PATH = $"{DOMAIN_URL}/api/Order";
        }
        public class OrderDetailAPIEndPoints
        {
            public static readonly string ORDER_DETAIL_PATH = $"{DOMAIN_URL}/api/OrderDetail";
        }
        public class ReviewAPIEndPoints
        {
            public static readonly string REVIEW_PATH = $"{DOMAIN_URL}/api/Review";
        }
        public class UserAPIEndPoints
        {
            public static readonly string USER_PATH = $"{DOMAIN_URL}/api/User";
        }
    }
}

