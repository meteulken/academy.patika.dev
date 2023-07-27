// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// out parametreler

// out parametreler, metotlara gönderilen parametrelerin metot içerisinde değiştirilerek geriye döndürülmesini sağlar.
// out parametreler, metot içerisinde değer atanmadan kullanılabilir.

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

    instance.Topla(4, 5, out int toplamSonucu);
    Console.WriteLine(toplamSonucu);


    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
    }