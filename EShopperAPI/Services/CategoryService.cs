using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using EShopperAPI.Services.Contracts;
using AutoMapper;
using EShopperAPI.Data.RequestDTO;

namespace EShopperAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryResponse>> GetAllCategories()
        {
            try
            {
                var categories = await _categoryRepository.GetAllCategories();
                return _mapper.Map<List<CategoryResponse>>(categories);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
