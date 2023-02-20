internal class Program
{
    private static void Main(string[] args)
    {
        //Atama ve İşlemli Atama
        int x = 3;
        int y = 3;
        y = y + 2;
        Console.WriteLine(y);
        y += 2; //y eşittir y artı 2 olarak yazmak yerine böyle ifade edebiliriz.
        Console.WriteLine(y);
        y /=1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);
    }
}