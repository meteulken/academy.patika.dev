
// :\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\hayvanlar.cs(18,14): error CS0060: Tutarsız erişilebilirlik: 'Hayvanlar' temel sınıfı, 'Kuslar' sınıfından daha az erişi
// lebilir [C:\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\kalitim.csproj]
// çözüm: Hayvanlar class'ının erişim belirleyicisini protected yapmak.
//

using System;


public class Hayvanlar : Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon yapar.");
    }
}

public class Surungenler : Hayvanlar
{
    public void SurunerekHareketEderler()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket eder.");
    }
}

public class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar.");
    }
}