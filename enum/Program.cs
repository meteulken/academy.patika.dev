
// enum (enumeration) -> belirli bir veri tipinin değişkenlerini tanımlamak için kullanılır.

// enum tanımlama

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik = 32;

    if(sicaklik <= (int)HavaDurumu.Normal)
        Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
    else if(sicaklik >= (int)HavaDurumu.Sicak)
        Console.WriteLine("Dışarıya çıkmak icin çok sıcak bir gün.");
    else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
        Console.WriteLine("Hadi dışarıya çıkalım.");






enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
}