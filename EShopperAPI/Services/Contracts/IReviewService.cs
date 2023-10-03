using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IReviewService
    {
        public Task<List<Review>> GetAllReviews();
    }
}
