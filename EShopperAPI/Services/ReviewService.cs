using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using EShopperAPI.Services.Contracts;
using AutoMapper;

namespace EShopperAPI.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<List<Review>> GetAllReviews()
        {
            try
            {
                var reviews = await _reviewRepository.GetAllReviews();
                return reviews;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
