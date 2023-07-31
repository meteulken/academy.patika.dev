using System.Collections;
using System;
using System.Collections.Generic;

// ArrayList ile List arasindaki farklar:
// ArrayList her türlü veri tipini tutabilirken, List sadece belirtilen veri tipini tutabilir.
// ArrayList performans olarak List'e göre daha yavastir.

ArrayList liste = new ArrayList();

// liste.Add("Ayse");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// Elemanlara erisim

// Console.WriteLine(liste[1]);

// foreach (var item in liste)
// {
//     Console.WriteLine(item);
// }

// // AddRange

// string[] renkler = {"Kirmizi", "Sari", "Yesil"};

List<int> sayilar = new List<int>() {1, 8, 3, 7, 9, 92, 5};

liste.AddRange(sayilar);

//liste.AddRange(renkler);

liste.Sort();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

Console.WriteLine("*** Sort ***");

// BinarySearch

Console.WriteLine(liste.BinarySearch(9));

// Reverse

Console.WriteLine("*** Reverse ***");

liste.Reverse();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Clear

// liste.Clear();

// Contains

Console.WriteLine("*** Contains ***");

if (liste.Contains(7))
{
    Console.WriteLine("10 liste icinde bulundu!");
}





