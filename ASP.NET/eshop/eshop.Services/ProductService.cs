using eshop.DataAccess.Repositories;
using eshop.Entities;

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

        public IEnumerable<Product> GetProducts(int categoryId = 0)
        {

            return categoryId == 0 ? productRepository.GetAll() :
                                     productRepository.GetProductsByCategoryId(categoryId);
        }
    }
}
