// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> list = new() { "A", "B" };
//string[] list2 = { "A", "B" };
//list2[2] = "C";
list.Add("C");

var cities = new string[] { "Ankara", "Adana", "İstanbul", "Eskişehir", "Muğla", "Çanakkale" };
var citiesStartWithA = filteredCities("A", cities);
foreach (var city in citiesStartWithA)
{
    Console.WriteLine(city);
}

if (!isCityFound("İzmir", cities))
{
    Console.WriteLine("İzmir şehirlerde yok!");
}

var index = findCityIndex("Ankara", cities);
Console.WriteLine($"Ankara'nın indexi: {index}");






bool isCityFound(string city, string[] cities)
{

    bool isFound = false;

    //for (int cityIndex = 0; cityIndex < cities.Length; cityIndex++)
    //{
    //    if (cities[cityIndex] == city)
    //    {
    //        isFound = true;
    //        break;
    //    }
    //}
    foreach (var item in cities)
    {
        if (item == city)
        {
            isFound = true;

            break;
        }
    }
    return isFound;
}

int findCityIndex(string city, string[] cities)
{
    int index = -1;
    for (int cityIndex = 0; cityIndex < cities.Length; cityIndex++)
    {
        if (cities[cityIndex] == city)
        {
            index = cityIndex;
            break;
        }
    }

    return index;
}

string[] filteredCities(string firstLetter, string[] cities)
{
    List<string> result = new List<string>();
    List<string> cityList = cities.ToList();

    foreach (var city in cityList)
    {
        if (city.StartsWith(firstLetter))
        {
            result.Add(city);


            //cityList.Remove(city);
        }
    }

    return result.ToArray();
}