
// :\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\hayvanlar.cs(18,14): error CS0060: Tutarsız erişilebilirlik: 'Hayvanlar' temel sınıfı, 'Kuslar' sınıfından daha az erişi
// lebilir [C:\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\kalitim.csproj]
// çözüm: Hayvanlar class'ının erişim belirleyicisini protected yapmak.
//

using System;


public class Hayvanlar:Canlilar
{
    public void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Hayvanlar uyaranlara tepki verir.");
    }

}

public class Sürüngenler:Hayvanlar{
    public Sürüngenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }

    public void SurunerekHareketEtmek()
    {
        Console.WriteLine("Sürüngeler sürünerek hareket ederler.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar");
    }
}