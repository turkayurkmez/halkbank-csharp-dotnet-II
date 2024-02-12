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
    }
}
