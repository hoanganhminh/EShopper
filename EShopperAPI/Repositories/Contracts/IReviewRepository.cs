using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface IReviewRepository
    {
        public Task<List<Review>> GetAllReviews();

    }
}
