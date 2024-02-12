using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            return new List<Category>()
            {
                new(){ Id = 1, Name="A Kategorisi"},
                new(){ Id = 2, Name="B Kategorisi"},
                new(){ Id = 3, Name="C Kategorisi"},

            };
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
