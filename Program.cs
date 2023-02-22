internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Atama ve İşlemli Atama Operatörleri");
        // Atama ve İşlemli Atama
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

        Console.WriteLine("*** Mantiksal Operatorler ***");

        // Mantıksal Operatörler
        // || (veya), && (ve), ! (değil)

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted) // ve operatörü ikisinin de true olması durumunda çalışır.
            Console.WriteLine("Perfect!");
       
        if(isSuccess || isCompleted) // veya operatörü ikisinden birinin true olması yeterlidir.
            Console.WriteLine("Great!");
        if(isSuccess && ! isCompleted) // değil önüne gelen ifadenin tersini alır. bu örnekte isCompleted değişkeni değillenince "true" olmuştur. isSuccess (true) "ve" ! isCompleted (true) sonucunda ikisi de true olunca "Fine" yazdırmıştır. 
            Console.WriteLine("Fine!");

        Console.WriteLine("*** İliskisel Operatorler ***");
        // İlişkisel Operatörler
        // <, >, <=, >=, ==, != (eşit değildir)
        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);

    Console.WriteLine("*** Aritmetik Operatorler ***");
    // Aritmetik Operatörler (+, -, *, /, % (mod alır- yani bölümden kalanı), ++ (1 arttırmak için, sayının önüne yazılır), --)

    int sayi1= 10;
    int sayi2 = 5;
    int sonuc1 = sayi1/sayi2;
    Console.WriteLine(sonuc1);
    sonuc1 = sayi1*sayi2;
    Console.WriteLine(sonuc1);
    sonuc1= sayi1 + sayi2;
    Console.WriteLine(sonuc1);
    sonuc1 = ++sayi1;
    // sonuc1= sayi1++ yapsaydık sayıyı 1 arttıracaktı ama yine 10 yazdıracaktı. Console.Writeline(sayi1) dersek 11 yazdığını görebiliriz.
    Console.WriteLine(sonuc1);

    // % mod alır (bir sayının bir sayıya bölümünden kalanı verir)
    int sonuc2 = 20%3;
    Console.WriteLine(sonuc2);








    }
}