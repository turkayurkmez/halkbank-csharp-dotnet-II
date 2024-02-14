using AutoMapper;
using eshop.DataAccess.Repositories;
using eshop.Entities;
using eshop.Services.DataTransferObjects.Request;
using eshop.Services.DataTransferObjects.Response;

namespace eshop.Services
{
    //uygulama product varlığı ile  ........... yapar dediğiniş her işlev buradadır
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<int> CreateAsync(CreateProductRequest productRequest)
        {
            var product = new Product
            {
                CategoryId = productRequest.CategoryId,
                Description = productRequest.Description,
                ImageUrl = productRequest.ImageUrl,
                Name = productRequest.Name,
                Price = productRequest.Price,
                Stock = productRequest.Stock,
            };
            await productRepository.CreateAsync(product);
            return product.Id;
        }

        public async Task<ProductForAddToCardResponse> GetProductAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            var dto = new ProductForAddToCardResponse()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };
            return dto;

        }

        public async Task<UpdateProductRequest> GetProductForUpdateAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            return new UpdateProductRequest
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
            };
        }

        public IEnumerable<ProductSummaryResponse> GetProducts(int categoryId = 0)
        {

            var products = categoryId == 0 ? productRepository.GetAll() :
                            productRepository.GetProductsByCategoryId(categoryId);

            var summaryResponses = products.Select(p => new ProductSummaryResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                CategoryId = categoryId
            });


            return summaryResponses;
        }

        public async Task<IEnumerable<ProductSummaryResponse>> GetProductsAsync(int categoryId = 0)
        {
            var products = categoryId == 0 ? await productRepository.GetAllAsync() :
                                             await productRepository.GetProductsByCategoryIdAsync(categoryId);

            var responses = mapper.Map<IEnumerable<ProductSummaryResponse>>(products);
            return responses;
        }

        public async Task<int> UpdateAsync(UpdateProductRequest productRequest)
        {
            var product = new Product()
            {
                CategoryId = productRequest.CategoryId,
                Description = productRequest.Description,
                Id = productRequest.Id,
                ImageUrl = productRequest.ImageUrl,
                Name = productRequest.Name,
                Price = productRequest.Price,
                Stock = productRequest.Stock
            };
            await productRepository.UpdateAsync(product);
            return product.Id;
        }
    }
}
