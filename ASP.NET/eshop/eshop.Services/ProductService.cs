using eshop.DataAccess.Repositories;
using eshop.Entities;
using eshop.Services.DataTransferObjects.Response;

namespace eshop.Services
{
    //uygulama product varlığı ile  ........... yapar dediğiniş her işlev buradadır
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Task<ProductForAddToCardResponse> GetProductAsync(int id)
        {
            var product = productRepository.GetById(id);
            var dto = new ProductForAddToCardResponse()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };
            return Task.FromResult(dto);

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
    }
}
