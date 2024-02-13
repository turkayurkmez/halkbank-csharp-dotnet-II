using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.Repositories
{
    public class FakeProductRepository : IProductRepository
    {

        private List<Product> _products = new List<Product>()
            {
                 new(){ Id=1, Name="Ürün A", Description="Ürün A açıklama", Price=1, CategoryId=1 },
                 new(){ Id=2, Name="Ürün B", Description="Ürün B açıklama", Price=5,CategoryId=2 },
                 new(){ Id=3, Name="Ürün C", Description="Ürün C açıklama", Price=10, CategoryId=3 },
                 new(){ Id=4, Name="Ürün D", Description="Ürün D açıklama", Price=15, CategoryId=1 },
                 new(){ Id=5, Name="Ürün A2", Description="Ürün A2 açıklama", Price=1, CategoryId=2 },
                 new(){ Id=6, Name="Ürün B3", Description="Ürün B3 açıklama", Price=5,CategoryId=3 },
                 new(){ Id=7, Name="Ürün C4", Description="Ürün C4 açıklama", Price=10,CategoryId=1 },
                 new(){ Id=8, Name="Ürün D5", Description="Ürün D5 açıklama", Price=15,CategoryId=2 }
            };
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int id) => _products.Where(p => p.CategoryId == id);


        public IEnumerable<Product> Search(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Search(decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
