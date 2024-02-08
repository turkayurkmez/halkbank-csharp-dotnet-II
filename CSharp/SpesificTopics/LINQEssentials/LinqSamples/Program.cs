// See https://aka.ms/new-console-template for more information
using LinqSamples;

Console.WriteLine("Hello, World!");

var products = ProductService.GetProducts();
var androidCount = products.Count(p => p.Description.Contains("Android"));

Console.WriteLine("Açıklamasında 'Android' geçenler " + androidCount);

var cheapestProducts = products.OrderBy(p => p.Price).Take(3).ToList();
Console.WriteLine("En ucuz üç ürün........................");
cheapestProducts.ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}"));
Console.WriteLine("-----------------------");
var firstAndroid = products.FirstOrDefault(p => p.Description.Contains("Android"));
Console.WriteLine($"Açıklamasında Android olan ilk ürün: {firstAndroid.Name}");

var collection = new List<string>() { "Sümer mah. Eskişehir", "Osmanağa  mh. Kadıköy" };
var address = collection.FirstOrDefault(a => a.Contains("Yozgat"), "Böyle bir adres yok");
Console.WriteLine(address);

var singleProduct = products.SingleOrDefault(p => p.Id == 1);

Console.WriteLine("Fiyat ve Rating'e göre sıralama");
Console.WriteLine("---------------------------------");
products.OrderBy(p => p.Price)
        .ThenByDescending(p => p.Rating)
        .ToList()
        .ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Rating}"));

var totalPrice = products.Sum(p => p.Price);
var averageRating = products.Average(p => p.Rating);
var maxPrice = products.Max(p => p.Price);
var minPrice = products.Min(p => p.Price);

Console.WriteLine($"----------------------");
Console.WriteLine($"Toplam fiyat {totalPrice}, ortalama {averageRating}, en pahalı ve en ucuz fiyat: {maxPrice} ve {minPrice} ");

var expensiveProduct = products.FirstOrDefault(p => p.Price == maxPrice);
Console.WriteLine(expensiveProduct.Name);

Console.WriteLine("---------");
Console.WriteLine(products.MaxBy(p => p.Price).Name);

Console.WriteLine(" ------- JOIN -------");

var categories = ProductService.GetCategories();
var joinResponse = categories.Join(inner: products,
                outerKeySelector: category => category,
                innerKeySelector: product => product.Category,
                resultSelector: (category, product) => new
                {
                    Kategori = category.Name,
                    Urun = product.Name,
                    Fiyat = product.Price
                }).ToList();



foreach (var item in joinResponse)
{
    Console.WriteLine($"{item.Kategori}\t{item.Urun}");
}


var pets = new List<Pet>()
{
    new() { Id=1, Name="Kedi"},
    new() { Id=2, Name="Köpek"},
    new() { Id=3, Name="Tavşan"}
};

var humans = new List<Human>()
{
    new() { Id=1, Name="A", PetId=1},
    new() { Id=2, Name="B", PetId=1},
    new() { Id=3, Name="C", PetId=2},

};

var output = pets.Join(inner: humans,
                       outerKeySelector: pet => pet.Id,
                       innerKeySelector: human => human.PetId,
                       resultSelector: (pet, human) => new
                       {
                           Isim = human.Name,
                           BesledigiHayvan = pet.Name
                       }
                       );

output.ToList().ForEach(r => Console.WriteLine($"{r.Isim}: {r.BesledigiHayvan}"));

var responseWithoutJoın = products.Select(p => new { p.Name, CategoryName = p.Category.Name });

Console.WriteLine("Join olmadan ürün kategorisine ulaşabilir miyiz?");
Console.WriteLine("--------------------------------------------------");
foreach (var item in responseWithoutJoın)
{
    Console.WriteLine($"{item.CategoryName}\t{item.Name}");
}

/*
 * Hangi kategoride kaç ürün var?
 * SELECT 
 *     CategoryName, Count(ProductId)
 * FROM Products 
 * GROUP BY CategoryName 
 */

var groupByQuery = products.GroupBy(keySelector: p => p.Description,
                                    elementSelector: element => new { element.Name, element.Price },
                                    resultSelector: (key, products) => new
                                    {
                                        Key = key,
                                        Count = products.Count(),
                                        SumPrice = products.Sum(p => p.Price),
                                        MaxPrice = products.Max(p => p.Price),

                                    }
                                   );

Console.WriteLine("Açıklamaya göre grup");
Console.WriteLine("---------------------------");
Console.WriteLine("Açıklama\tAdet\tToplam Fiyat");
foreach (var item in groupByQuery)
{
    Console.WriteLine($"{item.Key}\t\t{item.Count}\t{item.SumPrice}");
}


