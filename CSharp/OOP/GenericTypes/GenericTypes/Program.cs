// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

object p = "Naber";
object x = new Random();
object y = 3;

string greeting = (string)p;


object DoItAny(object o)
{
    Console.WriteLine(o);
    return o;
}

T DoItAnyGeneric<T>(T value)
{
    Console.WriteLine(value);
    return value;
}

bool IsEqual<T>(T x, T y) where T : IComparable<T>
{
    return x.CompareTo(y) == 0;
}


string response = (string)DoItAny("bu");
//string result = (string)DoItAny(8);

DoItAny(new string[] { "A", "B", "C" });
DoItAny(new FileStreamOptions());
DoItAnyGeneric(true);

if (IsEqual("a", "a"))
{
    Console.WriteLine("a ve a eşittir");
}
if (IsEqual(18, 18))
{
    Console.WriteLine("Eşittir");
}

