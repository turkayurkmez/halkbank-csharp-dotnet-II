// See https://aka.ms/new-console-template for more information
using LinqIntro;

Console.WriteLine("Hello, World!");

var value = new { Name = "Türkay", Age = 43 };
Console.WriteLine(value.Name);

var products = ProductService.GetProducts();
var result = from product in products
             where product.Rating >= 4.5
             select new { Ad = product.Name, Puan = product.Rating };



result.ToList().ForEach(p => Console.WriteLine(p.Ad + " " + p.Puan));
Console.WriteLine("*--------------- Same result but using extension -----------------");
var resultWithExtension = products.Where(p => p.Rating >= 4.5)
                                  .Select(p => new { Ad = p.Name, Puan = p.Rating })
                                  .OrderByDescending(p => p.Puan)
                                  .ToList();

resultWithExtension.ForEach(a => Console.WriteLine($"{a.Ad}\t{a.Puan}"));
