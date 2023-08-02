
using System.Collections.Generic;
using System.Linq;
using System;

// sınıflar ve nesneler
// sınıf: bir nesnenin özelliklerini ve metodlarını tanımlayan yapılardır.
// nesne: sınıfın özelliklerini ve metodlarını barındıran yapılardır.

Calisan calisan1 = new Calisan("Ayse", "Kara", 234567, "İnsan Kaynaklari"); // nesne oluşturma

// calisan1.Ad = "Ayse";
// calisan1.Soyad = "Kara";
// calisan1.No = 234567;
// calisan1.Departman = "İnsan Kaynaklari";

calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();

calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 123456;
calisan2.Departman = "Satin Alma";

calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan("Ahmet", "Yilmaz");
calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman) // kurucu metot (constructor)
    {
        this.Ad = ad; // this anahtar kelimesi ile sınıfın içerisindeki değişkenlere erişebiliriz.
        this.Soyad = soyad; 
        this.No = no;
        this.Departman = departman;
    }
    public Calisan() // kurucu metot (constructor)
    {
        
    }
    public Calisan(string ad, string soyad) // kurucu metot (constructor)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi: {0}", Ad);
        Console.WriteLine("Calisan Soyadi: {0}", Soyad);
        Console.WriteLine("Calisan Numarasi: {0}", No);
        Console.WriteLine("Calisan Departmani: {0}", Departman);
    }

};
