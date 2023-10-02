using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly EShopperContext _context;

        public ReviewRepository(EShopperContext context)
        {
            _context = context;
        }
        public async Task<List<Review>> GetAllReviews()
        {
            try
            {
                var reviews = await _context.Reviews.ToListAsync();
                return reviews;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
