using System.Collections.Generic;
using System;


// Dictionary yapisi, anahtar ve deger tutan bir koleksiyon yapisi olarak tanimlanabilir.
// Anahtarlar ve degerler ile islem yapilabilir.

Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(10, "Ayse Yilmaz");
kullanicilar.Add(12, "Ahmet Yilmaz");
kullanicilar.Add(18, "Deniz Arda");
kullanicilar.Add(20, "Özcan Coşar");

// Erisim

Console.WriteLine("*** Erisim ***");

Console.WriteLine(kullanicilar[12]);

foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

// Count

Console.WriteLine("*** Count ***");

Console.WriteLine(kullanicilar.Count);

// Contains

Console.WriteLine("*** Contains ***"); // ContainsKey, ContainsValue da kullanilabilir. 

Console.WriteLine(kullanicilar.ContainsKey(12)); // true döner.

Console.WriteLine(kullanicilar.ContainsValue("Ayse Yilmaz")); // true döner.

// Remove

Console.WriteLine("*** Remove ***");

kullanicilar.Remove(12); // 12 anahtarina sahip elemani siler.  

foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

// Keys

Console.WriteLine("*** Keys ***");

foreach (var item in kullanicilar.Keys) // Anahtarlar üzerinde gezinir.
{
    Console.WriteLine(item);
}

// Values

Console.WriteLine("*** Values ***");

foreach (var item in kullanicilar.Values) // Degerler üzerinde gezinir.
{
    Console.WriteLine(item);
}

// TryGetValue

Console.WriteLine("*** TryGetValue ***");

kullanicilar.TryGetValue(10, out string value); // 10 anahtarina sahip elemanin degerini value degiskenine atar.

Console.WriteLine(value); // Ayse Yilmaz



