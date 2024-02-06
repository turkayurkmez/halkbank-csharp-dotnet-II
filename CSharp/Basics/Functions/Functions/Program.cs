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

Tuple<int, int> divideAndTuple(int a, int b)
{
    var tuple = Tuple.Create(a / b, a % b);
    return tuple;
}

DivisionOutput divideAndObject(int a, int b)
{
    DivisionOutput output1 = new DivisionOutput
    {
        Result = a / b,
        Modulo = a % b,
    };
    return output1;

}





var outputOfDivide = divideAndObject(16, 5);
Console.WriteLine($"sonuç: {outputOfDivide.Result}\t kalan: {outputOfDivide.Modulo}");

(var sonuc, var bolumdenKalan) = divideAndTuple(13, 3);
Console.WriteLine($"Tuple ile Bölüm sonucu: {sonuc} ve kalan: {bolumdenKalan}");


string x = string.Empty;
(x, var y) = ("Selam", 3.14);


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



