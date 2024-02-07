// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static bool isAddedToDictionary(Dictionary<string, string> plates, bool isAdded)
{
    Console.WriteLine("Lütfen plaka kodu girin");
    string code = Console.ReadLine();

    //if (plates.ContainsKey(code))

    Console.WriteLine("Şimdi de şehir adı girin");
    string city = Console.ReadLine();


    if (!plates.TryAdd(code, city))
    {
        Console.WriteLine("Plaka eklenemedi, çünkü zaten var. Başka bir plaka deneyin!");
        isAdded = false;
    }
    else
    {
        Console.WriteLine("Başka bir plaka eklemek ister misiniz? (evet/hayir)");
        isAdded = true;
    }

    return isAdded;
}

string getCityFromPlates(Dictionary<string, string> plates, string code)
{
    string city = string.Empty;
    if (!plates.TryGetValue(code, out city))
    {
        city = "Bu kodda bir şehir yok!";
    }
    return city;
}

List<string> list = new List<string>();



Dictionary<string, string> plates = new Dictionary<string, string>();

//dictionaryDemo(plates);



void dictionaryDemo(Dictionary<string, string> plates)
{
    do
    {
        Console.WriteLine("1. Yeni plaka ekle");
        Console.WriteLine("2. Plaka Sorgula");
        Console.WriteLine("3. Çıkış");

        string choose = Console.ReadLine();

        switch (choose)
        {
            case "1":
                do
                {
                    bool isAdded = true;
                    do
                    {
                        isAdded = isAddedToDictionary(plates, isAdded);

                    } while (!isAdded);
                } while (Console.ReadLine() == "evet");
                break;
            case "2":
                do
                {
                    Console.WriteLine("Plaka giriniz:");
                    string code = Console.ReadLine();
                    var city = getCityFromPlates(plates, code);
                    Console.WriteLine(city);
                    Console.WriteLine("Başka bir sorgu? (e/h)");
                } while (Console.ReadLine() == "e");

                break;
            default:
                break;
        }

        Console.WriteLine("Devam etmek ister misiniz? (e/h) ");

    } while (Console.ReadLine() == "e");
}

