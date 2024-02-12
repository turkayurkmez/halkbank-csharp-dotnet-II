using eshop.Entities;

namespace eshop.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
    }
}