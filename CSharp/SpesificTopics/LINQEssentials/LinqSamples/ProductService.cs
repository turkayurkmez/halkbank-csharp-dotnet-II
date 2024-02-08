using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; } = new Category();

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class ProductService
    {

        private static List<Category> categories = new()
            {
                new(){ Id=1, Name="Mobil"},
                new(){ Id=2, Name="Giyim"},
                new(){ Id=3, Name="Kozmetik"},


            };

        public static List<Category> GetCategories()
        {
            return categories;
        }
        public static List<Product> GetProducts()
        {



            return new List<Product>()
            {
                new(){ Id = 1, Name="Samsung A51", Description="Android", Price=35000, Rating=4.3, Category=categories[0] },
                new(){ Id = 2, Name="Huawei S22", Description="Android", Price=25000, Rating=4.8, Category=categories[0]},
                new(){ Id = 3, Name="IPhone 15", Description="IoS", Price=85000, Rating=4.0, Category=categories[0]},
                new(){ Id = 4, Name="Samsung Watch", Description="Android", Price=6000, Rating=4.3, Category=categories[0]},
                new(){ Id = 5, Name="Eldiven", Description="Giyim aksesuarı", Price=150, Rating=4.9,Category=categories[1]},
                new(){ Id = 6, Name="Rimel", Description="Kozmetik", Price=250, Rating=4.6,Category=categories[2]},
                new(){ Id = 7, Name="Dell Laptop", Description="Dell", Price=85000, Rating=4.4,Category=categories[0]},

            };

        }
    }
}
