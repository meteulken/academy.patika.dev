// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Metotlar - Methods

// Metotlar, bir programlama dilinde belli bir işi yapmak için kullanılan kod bloklarıdır.
// Metotlar, kod tekrarını önlemek, kodun okunabilirliğini artırmak ve programcıya kolaylık sağlamak için kullanılır.

// metot tanımlama
// erişim_belirteci geri_dönüş_tipi metot_adı(parametreListesi/argüman)
// {
//      metot gövdesi
// }

// erişim_belirteci: metoda erişim belirler. (public, private, internal, protected)
// geri_dönüş_tipi: metotun geriye döndüreceği değerin tipini belirler. (int, string, bool, double, float, char, void)
// metot_adı: metotlara verilen isimdir. (PascalCase)
// parametreListesi: metotlara gönderilen değerlerin tipini ve isimlerini belirler. (int sayi, string metin, bool durum)
// argüman: metotlara gönderilen değerlerdir. (5, "Merhaba Dünya", true)

// metot tanımlama
    int sayi1 = 5;
    int sayi2 = 6;

    int toplam = topla(sayi1, sayi2);

    Metotlar ornek = new Metotlar();
    ornek.EkranaYazdir("Merhaba Dünya!");
    ornek.EkranaYazdir(toplam.ToString());

    int sonuc = ornek.ArttirVeTopla(ref sayi1, ref sayi2);
    ornek.EkranaYazdir((sonuc).ToString());

 int topla (int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}


class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}

