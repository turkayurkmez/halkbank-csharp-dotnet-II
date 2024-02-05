// See https://aka.ms/new-console-template for more information
using Functions;

int divide(int a, int b, out int modulo)
{
    modulo = a % b;
    return a / b;
}

void sample(ref int number)
{
    number *= 2;
    Console.WriteLine($"sample metodu içinden: {number}");
}

int average(params int[] numbers)
{
    return (int)numbers.Average();
}






var avaerageOfHeats = average(6, 4, 9, 12, 8, 5);
Console.WriteLine($"Ortalama:{avaerageOfHeats}");

var value = 5;
Console.WriteLine($"Main değer: {value}");
sample(ref value);
Console.WriteLine($"Main değer: {value}");





int kalan = 0;
var output = divide(15, 2, out kalan);
Console.WriteLine($"Sonuç: {output}. Kalan: {kalan}");

int valueFromUser = 0;
if (int.TryParse(Console.ReadLine(), out valueFromUser))
{

}


Geometry geometry = new Geometry();
geometry.GetArea(5, 3, "Dikdörtgen");
Console.WriteLine($"Kare: {geometry.GetAreaOptional(4)}");
Console.WriteLine($"Daire: {geometry.GetAreaOptional(4, sekil: "Daire")}");
Console.WriteLine($"Üçgen: {geometry.GetAreaOptional(4, 3, sekil: "Üçgen")}");



