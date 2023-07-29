// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// out parametreler
// out parametreler, metotlara gönderilen parametrelerin metot içerisinde değiştirilerek geriye döndürülmesini sağlar.

string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);

if (sonuc)
{
    Console.WriteLine("Başarili!");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarisiz!");
}

Metotlar instance = new Metotlar();

instance.topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

int ifade = 999;

instance.Ekranayazdir(ifade);
instance.Ekranayazdir("Patika", "Dev");

// metot overloading
// metot overloading, aynı isimde birden fazla metot tanımlanmasına denir.

// metot imzası, metot adı ve parametrelerin tipi ve sayısına göre belirlenir.



class Metotlar
{
    public void topla(int a,int b, out int toplam)
    {
        toplam = a + b;
    }
    public void Ekranayazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void Ekranayazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void Ekranayazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}