// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface IKiyafet
{

}
public class UstGiyim : IKiyafet
{

}
public class Kazak : UstGiyim
{

}
public class KirmiziKazak : Kazak
{
}



public abstract class Insan
{
    public abstract void Konus();
    public abstract void EgitimAl();
    public abstract void Calis();

    public void Giy(IKiyafet kazak)
    {

    }
}