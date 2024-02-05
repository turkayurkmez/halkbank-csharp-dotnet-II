// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * sayısal
 *   - tam sayı
 *      byte, short, int, long
 *   - ondalıklı
 *      double, float, decimal
 * 
 * 
 *  sözel
 *    
 * 
 * 
 * mantıksal
 * 
 */

byte maxValueOfByte = 255;


sbyte minValueOfByte = -128;

short minValueOfShort = -32768;
ushort maxValueOfShort = 65535;


var pi = 3.14d;
var piFloat = 3.14f;
var piDecimal = 3.1459782m;

char letter = 'T';
string name = "Türkay";
string test1 = "abc";
String test2 = "abc";


bool isCool = true;


int x = minValueOfByte;
char first = name[0];



bool isException = false;
do
{
    try
    {
        isException = false;
        Console.WriteLine("İlk sayıyı giriniz:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı giriniz");
        int second = int.Parse(Console.ReadLine());
        int anotherInteger = firstNumber + second;
        checked
        {
            byte value = (byte)anotherInteger;
            int divide = firstNumber / second;
            Console.WriteLine($"Değerler toplamı: {value}, bölüm sonucu ise {divide}");

        }

    }
    catch (OverflowException)
    {
        isException = true;
        Console.WriteLine("Byte değeri, int'e çavrilemedi");
    }
    catch (FormatException)
    {
        isException = true;
        Console.WriteLine("Girdiğiniz değerler tam sayı olmalı!");
    }
    catch (DivideByZeroException)
    {
        isException = true;

        Console.WriteLine("Tam sayılar; 0'a bölünemez!");
    }
    catch (Exception ex)
    {
        isException = true;

        Console.WriteLine($"Bir hata meydana geldi. Hata mesajı:\n{ex.Message}");
        //Çalışır ama daha yavaş çalışır!
        //if (ex is DivideByZeroException)
        //{

        //}
        //else if(ex is FormatException)
        //{

        //}
    }
    finally
    {
        //dispose gibi mutlaka çalışması gereken kodlar....

    }
} while (isException);








