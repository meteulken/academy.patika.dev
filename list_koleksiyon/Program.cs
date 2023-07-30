using System;
using System.Collections.Generic;

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();

renkListesi.Add("Kirmizi");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sari");
renkListesi.Add("Yeşil");

// Count

Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

// Foreach ve List.ForEach ile elemanlara erişim

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
foreach (var renk in renkListesi)   
{
    Console.WriteLine(renk); 
}



sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); // Daha hizli calisir
renkListesi.ForEach(renk => Console.WriteLine(renk)); // Daha hizli calisir

// Listeden eleman çıkarma

sayiListesi.Remove(4);

renkListesi.Remove("Yeşil");

sayiListesi.RemoveAt(0); // 0. indexteki elemani siler

renkListesi.RemoveAt(1); // 1. indexteki elemani siler

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Listede eleman arama

if(sayiListesi.Contains(10))
    Console.WriteLine("10 Liste içerisinde bulundu!");

// Eleman ile indexe erişme

Console.WriteLine(renkListesi.BinarySearch("Sari"));

// Diziyi List'e çevirme

string[] hayvanlar = {"Kedi", "Kopek", "Kus"};

List<string> hayvanListesi = new List<string>(hayvanlar);

// Listeyi nasıl temizleriz

hayvanListesi.Clear();

// List içerisinde nesne tutmak

List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();

kullanici1.Isim = "Mete";
kullanici1.Soyisim = "Jen";
kullanici1.Yas = 24;

Kullanicilar kullanici2 = new Kullanicilar();

kullanici2.Isim = "Mete2";
kullanici2.Soyisim = "Jen2";
kullanici2.Yas = 25;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar(){  
    Isim = "Mete3",
    Soyisim = "Jen3",
    Yas = 26
});

foreach (var kullanici in kullaniciListesi) 
{ 
    Console.WriteLine("Kullanici Adi: " + kullanici.Isim); 
    Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim); 
    Console.WriteLine("Kullanici Yas: " + kullanici.Yas);
}

yeniListe.Clear();

public class Kullanicilar{

    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }

    public string Soyisim { get => soyisim; set => soyisim = value; } 

    public int Yas { get => yas; set => yas = value; } 
}