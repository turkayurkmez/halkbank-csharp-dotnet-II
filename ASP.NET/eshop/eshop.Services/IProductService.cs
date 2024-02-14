using eshop.Entities;
using eshop.Services.DataTransferObjects.Request;
using eshop.Services.DataTransferObjects.Response;

namespace eshop.Services
{
    public interface IProductService
    {
        IEnumerable<ProductSummaryResponse> GetProducts(int categoryId = 0);
        Task<IEnumerable<ProductSummaryResponse>> GetProductsAsync(int categoryId = 0);
        Task<ProductForAddToCardResponse> GetProductAsync(int id);

        Task<UpdateProductRequest> GetProductForUpdateAsync(int id);

        Task<int> CreateAsync(CreateProductRequest productRequest);
        Task<int> UpdateAsync(UpdateProductRequest productRequest);



    }
}