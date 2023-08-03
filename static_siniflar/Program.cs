using System;

// static sınıfların içerisinde static olmayan bir şey olamaz.

    Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

    Calisan calisan = new Calisan("Ayşe", "Kara", "İnsan Kaynakları");

    Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

    Calisan calisan2 = new Calisan("Deniz", "Arda", "İnsan Kaynakları");

    Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

    calisan.BilgileriGoster();

    Console.WriteLine("Toplama islemi sonuc :{0}", Islemler.Topla(100, 200));
    Console.WriteLine("Çıkarma islemi sonuc :{0}", Islemler.Cikar(400, 50));

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        CalisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        CalisanSayisi++;
    }

    public void BilgileriGoster()
    {
        Console.WriteLine("Çalışanın Adı: {0}", this.Isim);
        Console.WriteLine("Çalışanın Soyadı: {0}", this.Soyisim);
        Console.WriteLine("Çalışanın Departmanı: {0}", this.Departman);
    }

    public static void CalisanSayisiniGoster()
    {
        Console.WriteLine("Toplam Çalışan Sayısı: {0}", CalisanSayisi);
    }   


};

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    } 
}