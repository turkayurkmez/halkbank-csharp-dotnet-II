using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> Search(string name);
        IEnumerable<Product> Search(decimal minPrice, decimal maxPrice);

        IEnumerable<Product> GetProductsByCategoryId(int id);

        Task<IEnumerable<Product>> SearchAsync(string name);
        Task<IEnumerable<Product>> SearchAsync(decimal minPrice, decimal maxPrice);
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int id);


    }
}
