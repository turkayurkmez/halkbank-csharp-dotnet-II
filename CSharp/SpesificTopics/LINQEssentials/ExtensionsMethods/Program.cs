// See https://aka.ms/new-console-template for more information
using ExtensionsMethods;

Console.WriteLine("Hello, World!");

int x = 8;
Console.WriteLine(x.GetSquare());
string name = "mEhMet aLİ Birand";

Console.WriteLine(name.ToTitleCase());

var totalWorkDays = DateTime.Now.TotalWorkDaysInYear(new() { new(2024, 4, 23), new(2024, 5, 19) });
Console.WriteLine(totalWorkDays.ToString());

