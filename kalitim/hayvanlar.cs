
// :\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\hayvanlar.cs(18,14): error CS0060: Tutarsız erişilebilirlik: 'Hayvanlar' temel sınıfı, 'Kuslar' sınıfından daha az erişi
// lebilir [C:\Users\mete_\Desktop\patika\academy.patika.dev\kalitim\kalitim.csproj]
// çözüm: Hayvanlar class'ının erişim belirleyicisini protected yapmak.
//

using System;


public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        System.Console.WriteLine("Hayvanlar adaptasyon kurabilir");
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
        System.Console.WriteLine("Sürüngeler sürünerek hareket ederler.");
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
    }
    public void Ucmak()
    {
        System.Console.WriteLine("Kuşlar uçar");
    }
}