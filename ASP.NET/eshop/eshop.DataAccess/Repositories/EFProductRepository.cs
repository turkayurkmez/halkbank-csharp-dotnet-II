using eshop.DataAccess.DataContext;
using eshop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EshopDbContext dbContext;

        public EFProductRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(Product entity)
        {
            await dbContext.Products.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var findingProduct = await dbContext.Products.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
            dbContext.Products.Remove(findingProduct);
            await dbContext.SaveChangesAsync();
        }

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.AsNoTracking().SingleOrDefault(p => p.Id == id);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await dbContext.Products.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int id)
        {
            return dbContext.Products.Where(p => p.CategoryId == id).AsEnumerable();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int id)
        {
            return await dbContext.Products.Where(p => p.CategoryId == id).ToListAsync();
        }

        public IEnumerable<Product> Search(string name)
        {
            return dbContext.Products.Where(p => p.Name.Contains(name)).ToList();
        }

        public IEnumerable<Product> Search(decimal minPrice, decimal maxPrice)
        {
            return dbContext.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public async Task<IEnumerable<Product>> SearchAsync(string name)
        {
            return await dbContext.Products.Where(p => p.Name.Contains(name)).ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchAsync(decimal minPrice, decimal maxPrice)
        {
            return await dbContext.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToListAsync();

        }

        public async Task UpdateAsync(Product entity)
        {
            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
