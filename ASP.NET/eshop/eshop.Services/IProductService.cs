using eshop.Entities;

namespace eshop.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts(int categoryId = 0);
    }
}