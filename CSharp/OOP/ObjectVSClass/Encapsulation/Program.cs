// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

decimal value = -5;

//if (value<0)
//{
//    throw new Exception("fiyat 0'dan küçük olamaz");
//}

Product product = new Product();
product.SetPrice(-15);
product.Name = "Dell XPS 13";

//product.price  = value;
Console.WriteLine(product.Description);
product.Description = "16 GB Ram";
product.IncreaseStock(50);
Console.WriteLine(product.StockCount);