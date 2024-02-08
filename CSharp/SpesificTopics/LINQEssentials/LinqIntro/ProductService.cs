using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntro
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }

    }

    public static class ProductService
    {
        public static List<Product> GetProducts() =>
            new List<Product>()
            {
                new(){ Id = 1, Name="Samsung A51", Description="Android", Price=35000, Rating=4.3},
                new(){ Id = 2, Name="Huawei S22", Description="Android", Price=25000, Rating=4.8},
                new(){ Id = 3, Name="IPhone 15", Description="IoS", Price=85000, Rating=4.0},
                new(){ Id = 4, Name="Samsung Watch", Description="Android", Price=6000, Rating=4.3},
                new(){ Id = 5, Name="Eldiven", Description="Giyim aksesuarı", Price=150, Rating=4.9},
                new(){ Id = 6, Name="Rimel", Description="Kozmetik", Price=250, Rating=4.6}

            };
    }
}
