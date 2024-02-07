// See https://aka.ms/new-console-template for more information
using usingDelegate;

Console.WriteLine("Hello, World!");
var numbers = Enumerable.Range(1, 10).ToArray();




bool isEven(int number)
{
    return number % 2 == 0;
}

void show(List<int> numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

void alternateShow(List<int> numbers) => numbers.ForEach(number => Console.WriteLine(number));

//.NET 1.1 -> 2003
var evens = FilterHelper.Filter(numbers, isEven);

show(evens);
// .NET 2.0
Console.WriteLine("------ .NET 2.0");
var odds = FilterHelper.Filter(numbers,
delegate (int number)
{
    return number % 2 == 1;
});

show(odds);

// .NET 3.0
Console.WriteLine("--------------");
var multipleOfThree = FilterHelper.Filter(numbers, number => number % 3 == 0);
alternateShow(multipleOfThree);


