
// enum (enumeration) -> belirli bir veri tipinin değişkenlerini tanımlamak için kullanılır.

// enum tanımlama

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

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

enum HavaDurumu : byte
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
}