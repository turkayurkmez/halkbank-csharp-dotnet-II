
//değerleri bilmiyorum. Eleman sayısını biliyorum:
string[] days = new string[7];
days[0] = "Pazartesi";
days[6] = "Pazar";

//elemanları biliyorum:
string[] months = { "Ocak", "Aralık" };

/*
 * 42
 * 
 * Kırk iki
 * 
 */
string yaziyaCevir(int sayi)
{
    int onlarBasamagindakiDeger = sayi / 10;
    int birlerDegeri = sayi % 10;

    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

    return $"{onlar[onlarBasamagindakiDeger]}{birler[birlerDegeri]}";

}



Console.WriteLine("Bir sayı giriniz:");

int sayi = int.Parse(Console.ReadLine());
//int onlarBasamagindakiDeger = sayi / 10;
//int birlerDegeri = sayi % 10;

//string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
//string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };


//Console.WriteLine($"{onlar[onlarBasamagindakiDeger]}{birler[birlerDegeri]}");
Console.WriteLine(yaziyaCevir(sayi));

for (int number = 1; number < 100; number++)
{
    //onlarBasamagindakiDeger = number / 10;
    //birlerDegeri = number % 10;
    Console.WriteLine(yaziyaCevir(number));
}










