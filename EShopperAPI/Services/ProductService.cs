using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using EShopperAPI.Services.Contracts;
using AutoMapper;
using EShopperAPI.Data.RequestDTO;

namespace EShopperAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductResponse>> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.GetAllProducts();
                return _mapper.Map<List<ProductResponse>>(products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
