// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Employee accountant = new Employee();
accountant.Name = "Zeynep";
accountant.Age = 30;

Employee developer = accountant;
developer.Name = "Türkay";
accountant.Name = "Necmiye";


Console.WriteLine(developer.Name);