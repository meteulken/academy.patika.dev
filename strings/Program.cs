// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";

Console.WriteLine(degisken.Length); // Karakter sayısı

Console.WriteLine(degisken.ToLower()); // Küçük harfe çevirir
Console.WriteLine(degisken.ToUpper()); // Büyük harfe çevirir

Console.WriteLine(String.Concat(degisken," Merhaba!")); // degisken + " Merhaba!"

Console.WriteLine(degisken.CompareTo(degisken2)); // 0 eşit, 1 büyük, -1 küçük

Console.WriteLine(String.Compare(degisken,degisken2,true)); // true ise büyük küçük harf duyarlılığı yok
Console.WriteLine(String.Compare(degisken,degisken2,false)); // false ise büyük küçük harf duyarlılığı var

Console.WriteLine(degisken.Contains(degisken2)); // degisken içerisinde degisken2 var mı?

Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // degisken "Hoşgeldiniz!" ile bitiyor mu?

Console.WriteLine(degisken.StartsWith("Merhaba!")); // degisken "Merhaba!" ile başlıyor mu?

Console.WriteLine(degisken.IndexOf("CS")); // degisken içerisinde "CS" geçiyor mu? Geçiyorsa kaçıncı karakterden itibaren geçiyor?

Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // degiskenin 0. karakterinden itibaren "Merhaba! " ekle

Console.WriteLine(degisken.LastIndexOf("i")); // degisken içerisinde "i" geçiyor mu? Geçiyorsa kaçıncı karakterden itibaren geçiyor?

Console.WriteLine(degisken.PadLeft(50)); // degiskeni 50 karakterlik bir alana yerleştir ve sağa daya
Console.WriteLine(degisken.PadLeft(50,'*')); // degiskeni 50 karakterlik bir alana yerleştir ve sağa daya, boşluk yerine * koy (varsayılan boşluk
Console.WriteLine(degisken.PadRight(50,'-')); // degiskeni 50 karakterlik bir alana yerleştir ve sola daya, boşluk yerine - koy (varsayılan boşluk
Console.WriteLine(degisken.PadRight(50) + degisken2); // degiskeni 50 karakterlik bir alana yerleştir ve sola daya

Console.WriteLine(degisken.PadRight(50)); // degiskeni 50 karakterlik bir alana yerleştir ve sola daya

Console.WriteLine(degisken.Remove(10)); // degiskenin 10. karakterinden itibaren sil
Console.WriteLine(degisken.Remove(0,1)); // degiskenin 0. karakterinden itibaren 1 karakter sil
Console.WriteLine(degisken.Remove(5,3)); // degiskenin 5. karakterinden itibaren 3 karakter sil

Console.WriteLine(degisken.Replace("CSharp","C#")); // degisken içerisinde "CSharp" varsa "C#" ile değiştir

Console.WriteLine(degisken.Split(" ")[1]); // degiskeni " " boşluk karakterinden itibaren ayır ve 1. elemanı yazdır

Console.WriteLine(degisken.Substring(4)); // degiskenin 4. karakterinden itibaren yazdır

Console.WriteLine(degisken.Substring(4,6)); // degiskenin 4. karakterinden itibaren 6 karakter yazdır

Console.WriteLine(degisken.Trim()); // degiskenin başında ve sonunda bulunan boşlukları sil

Console.WriteLine(degisken.TrimStart()); // degiskenin başında bulunan boşlukları sil

Console.WriteLine(degisken.TrimEnd()); // degiskenin sonunda bulunan boşlukları sil





