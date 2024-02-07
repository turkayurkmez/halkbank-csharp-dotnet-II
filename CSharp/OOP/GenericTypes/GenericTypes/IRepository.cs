using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IEntity
    {

    }
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }

    public interface IRequestRepository<T> where T : class, IEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

        T GetEntity(int id);

    }
}
