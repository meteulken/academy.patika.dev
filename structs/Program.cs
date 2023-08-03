
// struct nedir ?
// struct yapısı, değer tipinde bir veri tutmak için kullanılır.
// struct yapısı ile oluşturulan bir nesne stack'te tutulur.

// class nedir ?
// class yapısı, referans tipinde bir veri tutmak için kullanılır.
// class yapısı ile oluşturulan bir nesne heap'te tutulur.
// class yapısı ile oluşturulan bir nesne new anahtar kelimesi ile oluşturulur.

Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;

Console.WriteLine("Class Alan Hesapla :{0}",dikdortgen.AlanHesapla());

DikdortgenStruct dikdortgenStruct;

dikdortgenStruct.KisaKenar = 3;
dikdortgenStruct.UzunKenar = 4;

Console.WriteLine("Struct Alan Hesapla :{0}",dikdortgenStruct.AlanHesapla());


class Dikdortgen
{
    public int KisaKenar { get; set; }
    public int UzunKenar { get; set; }

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

struct DikdortgenStruct
{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}